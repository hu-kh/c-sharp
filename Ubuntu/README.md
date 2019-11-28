# Compile, run and decompile C# code in Ubuntu terminal

### Install mono-complete. In all currently:
 `sudo apt install mono-complete`

### Save your C# code as hello.cs her's a hello world code:
```c#
using System;

namespace Project_1 {
    class MainClass {
        public static void Main (string[] args) {
            Console.WriteLine ("Hello World!");
            Console.ReadKey ();
        }
    }
}
```
### Make hello.cs executable:
`sudo chmod a+x hello.cs`

### Change directories using the cd command to the directory that contains the hello.cs file.


### Use the mcs compiler and create a Windows executable named hello.exe from the source hello.cs
`mcs -out:hello.exe hello.cs`

### Run the hello.exe program with mono.
`mono hello.exe`


### The results of running your program in step 6. should be:
`Hello World!`

### Press Enter to exit back to a default terminal prompt.


### Decompile the executable file.
`monodis --output=decompiled-hello.txt hello.exe`



---

### For Ubuntu 18.04
```
sudo apt install apt-transport-https dirmngr
sudo apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF
echo "deb https://download.mono-project.com/repo/ubuntu vs-bionic main" | sudo tee /etc/apt/sources.list.d/mono-official-vs.list
sudo apt update

```
