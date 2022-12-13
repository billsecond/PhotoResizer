using System.Drawing;

ResizeImage(@"C:\Users\wdaugherty\Pictures\test\HouDown.jpg", @"C:\Users\wdaugherty\Pictures\test\HouDown_800.jpg", 800);
ResizeImage(@"C:\Users\wdaugherty\Pictures\test\HouDown.jpg", @"C:\Users\wdaugherty\Pictures\test\HouDown_200.jpg", 200);

// Scales the image size down based on the width
static void ResizeImage(string sourcePath, string targtetPath, int width)
{
    using (var image = System.Drawing.Image.FromFile(sourcePath))
    {
        var ratio = (double)width / image.Width;
        var height = (int)(image.Height * ratio);
        var newImage = new Bitmap(width, height);
        using (var graphics = Graphics.FromImage(newImage))
        {
            graphics.DrawImage(image, 0, 0, width, height);
        }
        newImage.Save(targtetPath);
    }
}