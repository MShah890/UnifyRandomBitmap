# UnifyRandomBitmap

Open the solution file. It will open the project in Visual Studio. 

I have 3 files RandomService.cs, BitmapPictureService.cs and Program.cs

This is a console application which consumes the Random number service through the file RandomService.cs

The RandomService.cs method returns an array of 100 random numbers and the Main (Program.cs) passes it to BitmapPictureService.cs

The BitmpaPictureService.cs selects randomly from these 100 numbers and puts them in Red, Green and Blue values when plotting the pixel.

The final 128x128 bitmap image is in the Images folder in root directory.

