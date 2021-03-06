﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using Shadowsocks.Util;

namespace Shadowsocks.Obfs
{
	// Token: 0x02000010 RID: 16
	public class AuthSimple : VerifySimpleBase
	{
		// Token: 0x060000C3 RID: 195 RVA: 0x0000D2AD File Offset: 0x0000B4AD
		public AuthSimple(string method) : base(method)
		{
			this.has_sent_header = false;
			this.has_recv_header = false;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000D5EC File Offset: 0x0000B7EC
		public override byte[] ClientPostDecrypt(byte[] plaindata, int datalength, out int outlength)
		{
			byte[] array = new byte[this.recv_buf_len + datalength];
			Array.Copy(plaindata, 0, this.recv_buf, this.recv_buf_len, datalength);
			this.recv_buf_len += datalength;
			outlength = 0;
			while (this.recv_buf_len > 2)
			{
				int num = ((int)this.recv_buf[0] << 8) + (int)this.recv_buf[1];
				if (num >= 8192 || num < 7)
				{
					throw new ObfsException("ClientPostDecrypt data error");
				}
				if (num > this.recv_buf_len)
				{
					break;
				}
				if (!CRC32.CheckCRC32(this.recv_buf, num))
				{
					throw new ObfsException("ClientPostDecrypt data uncorrect CRC32");
				}
				int num2 = (int)(this.recv_buf[2] + 2);
				int num3 = num - num2 - 4;
				if (outlength + num3 > array.Length)
				{
					Array.Resize<byte>(ref array, (outlength + num3) * 2);
				}
				Array.Copy(this.recv_buf, num2, array, outlength, num3);
				outlength += num3;
				this.recv_buf_len -= num;
				Array.Copy(this.recv_buf, num, this.recv_buf, 0, this.recv_buf_len);
			}
			return array;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000D490 File Offset: 0x0000B690
		public override byte[] ClientPreEncrypt(byte[] plaindata, int datalength, out int outlength)
		{
			int expr_01 = datalength;
			byte[] array = new byte[expr_01 + expr_01 / 10 + 32];
			byte[] array2 = new byte[9000];
			byte[] array3 = plaindata;
			outlength = 0;
			if (!this.has_sent_header)
			{
				int headSize = ObfsBase.GetHeadSize(plaindata, 30);
				int num = Math.Min(this.random.Next(32) + headSize, datalength);
				int num2;
				this.PackAuthData(array3, num, array2, out num2);
				this.has_sent_header = true;
				if (array.Length < outlength + num2)
				{
					Array.Resize<byte>(ref array, (outlength + num2) * 2);
				}
				Array.Copy(array2, 0, array, outlength, num2);
				outlength += num2;
				datalength -= num;
				byte[] array4 = new byte[datalength];
				Array.Copy(array3, num, array4, 0, array4.Length);
				array3 = array4;
			}
			while (datalength > 8100)
			{
				int num3;
				this.PackData(array3, 8100, array2, out num3);
				if (array.Length < outlength + num3)
				{
					Array.Resize<byte>(ref array, (outlength + num3) * 2);
				}
				Array.Copy(array2, 0, array, outlength, num3);
				outlength += num3;
				datalength -= 8100;
				byte[] array5 = new byte[datalength];
				Array.Copy(array3, 8100, array5, 0, array5.Length);
				array3 = array5;
			}
			if (datalength > 0)
			{
				int num4;
				this.PackData(array3, datalength, array2, out num4);
				if (array.Length < outlength + num4)
				{
					Array.Resize<byte>(ref array, (outlength + num4) * 2);
				}
				Array.Copy(array2, 0, array, outlength, num4);
				outlength += num4;
			}
			return array;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00009AEF File Offset: 0x00007CEF
		public override void Dispose()
		{
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000D2D5 File Offset: 0x0000B4D5
		public override Dictionary<string, int[]> GetObfs()
		{
			return AuthSimple._obfs;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000D2DC File Offset: 0x0000B4DC
		public override object InitData()
		{
			return new AuthData();
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000D338 File Offset: 0x0000B538
		public void PackAuthData(byte[] data, int datalength, byte[] outdata, out int outlength)
		{
			int num = this.random.Next(250) + 1;
			outlength = num + datalength + 6 + 12;
			AuthData authData = (AuthData)this.Server.data;
			AuthData obj = authData;
			lock (obj)
			{
				if (authData.connectionID > 4278190080u)
				{
					authData.clientID = null;
				}
				if (authData.clientID == null)
				{
					authData.clientID = new byte[4];
					AuthSimple.g_random.GetBytes(authData.clientID);
					authData.connectionID = (uint)this.random.Next(16777216);
				}
				authData.connectionID += 1u;
				Array.Copy(authData.clientID, 0, outdata, num + 4 + 2, 4);
				Array.Copy(BitConverter.GetBytes(authData.connectionID), 0, outdata, num + 8 + 2, 4);
			}
			Array.Copy(BitConverter.GetBytes((uint)((ulong)Math.Floor(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds))), 0, outdata, num + 2, 4);
			Array.Copy(data, 0, outdata, num + 12 + 2, datalength);
			outdata[0] = (byte)(outlength >> 8);
			outdata[1] = (byte)outlength;
			outdata[2] = (byte)num;
			CRC32.SetCRC32(outdata, outlength);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000D2E4 File Offset: 0x0000B4E4
		public void PackData(byte[] data, int datalength, byte[] outdata, out int outlength)
		{
			int num = this.random.Next(16) + 1;
			outlength = num + datalength + 6;
			if (datalength > 0)
			{
				Array.Copy(data, 0, outdata, num + 2, datalength);
			}
			outdata[0] = (byte)(outlength >> 8);
			outdata[1] = (byte)outlength;
			outdata[2] = (byte)num;
			CRC32.SetCRC32(outdata, outlength);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000D2C4 File Offset: 0x0000B4C4
		public static List<string> SupportedObfs()
		{
			return new List<string>(AuthSimple._obfs.Keys);
		}

		// Token: 0x040000C0 RID: 192
		protected static RNGCryptoServiceProvider g_random = new RNGCryptoServiceProvider();

		// Token: 0x040000BF RID: 191
		protected bool has_recv_header;

		// Token: 0x040000BE RID: 190
		protected bool has_sent_header;

		// Token: 0x040000BD RID: 189
		private static Dictionary<string, int[]> _obfs = new Dictionary<string, int[]>
		{
			{
				"auth_simple",
				new int[]
				{
					1,
					0,
					1
				}
			}
		};
	}
}
