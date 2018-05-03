using System;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace Task6.BLL.Services
{
	public class ProtectedStream : Stream
	{
		private readonly string _currentPassword = GetHashString("MyPassword");
		public bool IsAuthorize { get; private set; }
		private readonly Stream _stream;

		public override bool CanRead { get; }
		public override bool CanSeek { get; }
		public override bool CanWrite { get; }

		public override long Length => _stream.Length;

		public override long Position { get; set; }

		public ProtectedStream(Stream stream, string password)
		{
			_stream = stream;

			if (password == null)
			{
				IsAuthorize = false;
			}
			else if (GetHashString(password) == _currentPassword)
			{
				IsAuthorize = true;
			}
			else
			{
				IsAuthorize = false;
			}
		}

		public override void Flush()
		{
			_stream.Flush();
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return _stream.Seek(offset, origin);
		}

		public override void SetLength(long value)
		{
			_stream.SetLength(value);
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			if (IsAuthorize)
			{
				return _stream.Read(buffer, offset, count);
			}
			else
			{
				throw new ArgumentException("ERROR: Wrong password!");
			}	
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
		    _stream.Write(buffer, offset, count);
		}

		private static string GetHashString(string str)
		{
			var bytes = Encoding.Unicode.GetBytes(str);
			var csp = new MD5CryptoServiceProvider();

			var byteHash = csp.ComputeHash(bytes);

			var hash = string.Empty;

			foreach (var b in byteHash)
			{
				hash += $"{b:x2}";
			}

			return hash;
		}
	}
}
