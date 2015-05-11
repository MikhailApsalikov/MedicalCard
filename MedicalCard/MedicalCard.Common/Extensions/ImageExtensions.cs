namespace System
{
	using Drawing;
	using Drawing.Imaging;
	using IO;

	public static class ImageExtensions
	{
		public static byte[] ImageToByteArray(this Image imageIn)
		{
			var ms = new MemoryStream();
			imageIn.Save(ms, ImageFormat.Bmp);
			return ms.ToArray();
		}
	}
}