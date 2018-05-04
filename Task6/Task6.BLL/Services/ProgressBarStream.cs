using System;
using System.IO;
using Task6.BLL.Interfaces;

namespace Task6.BLL.Services
{
	public class ProgressBarStream: Stream
	{
		private readonly Stream _stream;

		public override bool CanRead { get; }
		public override bool CanSeek { get; }
		public override bool CanWrite { get; }
		public override long Length { get; }
		public override long Position { get; set; }
		public double Percent { get; private set; }

		public delegate void ProgressStateHandler(double per);

		public event ProgressStateHandler Progress;

		public ProgressBarStream(Stream stream, double percent)
		{
			_stream = stream;
			Length = stream.Length;
			Percent = percent;
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			Progress?.Invoke(Percent);

			return _stream.Read(buffer, offset, count);
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

		public override void Write(byte[] buffer, int offset, int count)
		{
			_stream.Write(buffer, offset, count);
		}
	}
}
