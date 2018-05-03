using System;
using System.IO;
using Task6.BLL.Interfaces;

namespace Task6.BLL.Services
{
	public class ProgressBarStream: Stream
	{
		private readonly Stream _stream;
		private readonly IProgressBar _progressBar;

		public int Percent { get; private set; }

		public override bool CanRead { get; }
		public override bool CanSeek { get; }
		public override bool CanWrite { get; }
		public override long Length { get; }
		public override long Position { get; set; }

		public ProgressBarStream(Stream stream, IProgressBar progressBar)
		{
			_stream = stream;
			_progressBar = progressBar;
		}

		public override int Read(byte[] buffer, int offset, int percent)
		{
			var count = _stream.Length / 100.0 * percent;
			for (var i = 1; i <= percent; i++)
			{
				_progressBar.DisplayProgress(i, 100);
			}

			return _stream.Read(buffer, offset, (int)count);
		}

		public override void Flush()
		{
			throw new NotImplementedException();
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotImplementedException();
		}

		public override void SetLength(long value)
		{
			throw new NotImplementedException();
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new NotImplementedException();
		}
	}
}
