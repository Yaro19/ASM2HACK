using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using ASM2HACK;

namespace ASM2HACK
{
    public class Program
    {
        public static void Main()
        {
            string pathDir = @"C:\Users\User\Desktop\Universita'\Architettura degli Elaboratori e Sistemi Operativi\Laboratorio\Projects\Project06\pong";

            string pathASMFile = pathDir+@"\Pong.asm";

            

            Assembler assembler = new Assembler(pathASMFile, pathDir, "Pong");

            

            assembler.Assemble();

        }
    }
}