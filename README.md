# NyaaNet

NyaaNet is an easy to use api client built around the [Nyaa-Api-Go](https://github.com/Yash-Garg/Nyaa-Api-Go) server written by [Yash Garg](https://github.com/Yash-Garg). Its purpose is to provide an easy-to-use C# api to search for and sort torrents on Nyaa.si.

# Building

Personally, the idea behind this project was to build a client that would be easy to use and easy to maintain. I wanted to make sure that the client had a minimal amount of dependencies and could be easy to build from source to deploy practically anywhere.

Building NyaaNet is dead simple:
 - Ensure visual studio is installed and configured for Dotnet development with the dotnet 6 SDK

- Open the Src.sln file in visual studio

- Click the build menu and select "Build Solution"

Congrats!🎉 If you have completed the above steps correctly, you should be able to see the NyaaNet.dll file in the bin/Debug folder. You can now use NyaaNet in your C# projects to connect to the [Nyaa-Api-Go](https://github.com/Yash-Garg/Nyaa-Api-Go) server and start searching for/sorting torrents from Nyaa.si.

# Learning how to use NyaaNet

## Documentation
The documentation for NyaaNet is currently in the works, and will be available soon. In the meantime, it is reccomended to look through the included Development Sample to get a better idea of how NyaaNet works.

## Using the Development Sample
Included in the solution is a sample WPF application called "NyaaNetSample" that allows the user to search for torrents and double click to open them in the default browser. Although the application is not complete, it is a good starting point for learning how to use the api.

