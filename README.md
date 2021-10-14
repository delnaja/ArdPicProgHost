# ArdPicProgHost
## GUI for Pic Programmer

If you would search the internet you will find quite some DIY pic programmers. However, those designs often either require a true seriell or parallel port instead of an easily available USB port or are designed around a pre-programmed controller assuming access to a programmer.

A compelling alternative would be the use of an Arduino as in the ArdPicProg. Load the Arduino sketch, the host program and add a prototype shield with a very limited number of additional components to build your pic programmer. This programmer features also a ICD connector and an RJ-11 jack (ICD2) interface. The complete project including hard- and software is open source and is released under the GNU General Public License Version 3. You can build your own ArdPicProg by using the available kit or especially designed PCB.

The complete setup and the application of the ArdPicProg is described in more detail on https://makerprojekte.de/en/arduino-pic-programmer/. This page also features a comprehensive User's Guide.

One element of the ArdPicProg - tool chain is a host software. You can select between two options: the terminal program "PicProgTerm" or the "ArdPicProgHost" application for Windows with a graphical user interface. The source code for both programs can be found in respective repositories on github/makerprojects.

Changes: 
24.05.2021: PIC16F627A, PIC16F628A and PIC16F648A support added

14.10.2021: PIC12F629, PIC12F675 support added – 5V PIC_VDD power supply via D2 arduino pin. OSCCAL is overwritten
