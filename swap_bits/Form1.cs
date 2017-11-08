﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace swap_bits
{
    public partial class Form1 : Form
    {
        
        static int[] font = {
            0x00, 0x00, 0x00, 0x00, 0x00,// (space)
	        0x00, 0x00, 0x5F, 0x00, 0x00,// !
	        0x00, 0x07, 0x00, 0x07, 0x00,// "
	        0x14, 0x7F, 0x14, 0x7F, 0x14,// #
	        0x24, 0x2A, 0x7F, 0x2A, 0x12,// $
	        0x23, 0x13, 0x08, 0x64, 0x62,// %
	        0x36, 0x49, 0x55, 0x22, 0x50,// &
	        0x00, 0x05, 0x03, 0x00, 0x00,// '
	        0x00, 0x1C, 0x22, 0x41, 0x00,// (
	        0x00, 0x41, 0x22, 0x1C, 0x00,// )
	        0x08, 0x2A, 0x1C, 0x2A, 0x08,// *
	        0x08, 0x08, 0x3E, 0x08, 0x08,// +
	        0x00, 0x50, 0x30, 0x00, 0x00,// ,
	        0x08, 0x08, 0x08, 0x08, 0x08,// -
	        0x00, 0x60, 0x60, 0x00, 0x00,// .
	        0x20, 0x10, 0x08, 0x04, 0x02,// /
	        0x3E, 0x51, 0x49, 0x45, 0x3E,// 0
	        0x00, 0x42, 0x7F, 0x40, 0x00,// 1
	        0x42, 0x61, 0x51, 0x49, 0x46,// 2
	        0x21, 0x41, 0x45, 0x4B, 0x31,// 3
	        0x18, 0x14, 0x12, 0x7F, 0x10,// 4
	        0x27, 0x45, 0x45, 0x45, 0x39,// 5
	        0x3C, 0x4A, 0x49, 0x49, 0x30,// 6
	        0x01, 0x71, 0x09, 0x05, 0x03,// 7
	        0x36, 0x49, 0x49, 0x49, 0x36,// 8
	        0x06, 0x49, 0x49, 0x29, 0x1E,// 9
	        0x00, 0x36, 0x36, 0x00, 0x00,// :
	        0x00, 0x56, 0x36, 0x00, 0x00,// ;
	        0x00, 0x08, 0x14, 0x22, 0x41,// <
	        0x14, 0x14, 0x14, 0x14, 0x14,// =
	        0x41, 0x22, 0x14, 0x08, 0x00,// >
	        0x02, 0x01, 0x51, 0x09, 0x06,// ?
	        0x32, 0x49, 0x79, 0x41, 0x3E,// @
	        0x7E, 0x11, 0x11, 0x11, 0x7E,// A
	        0x7F, 0x49, 0x49, 0x49, 0x36,// B
	        0x3E, 0x41, 0x41, 0x41, 0x22,// C
	        0x7F, 0x41, 0x41, 0x22, 0x1C,// D
	        0x7F, 0x49, 0x49, 0x49, 0x41,// E
	        0x7F, 0x09, 0x09, 0x01, 0x01,// F
	        0x3E, 0x41, 0x41, 0x51, 0x32,// G
	        0x7F, 0x08, 0x08, 0x08, 0x7F,// H
	        0x00, 0x41, 0x7F, 0x41, 0x00,// I
	        0x20, 0x40, 0x41, 0x3F, 0x01,// J
	        0x7F, 0x08, 0x14, 0x22, 0x41,// K
	        0x7F, 0x40, 0x40, 0x40, 0x40,// L
	        0x7F, 0x02, 0x04, 0x02, 0x7F,// M
	        0x7F, 0x04, 0x08, 0x10, 0x7F,// N
	        0x3E, 0x41, 0x41, 0x41, 0x3E,// O
	        0x7F, 0x09, 0x09, 0x09, 0x06,// P
	        0x3E, 0x41, 0x51, 0x21, 0x5E,// Q
	        0x7F, 0x09, 0x19, 0x29, 0x46,// R
	        0x46, 0x49, 0x49, 0x49, 0x31,// S
	        0x01, 0x01, 0x7F, 0x01, 0x01,// T
	        0x3F, 0x40, 0x40, 0x40, 0x3F,// U
	        0x1F, 0x20, 0x40, 0x20, 0x1F,// V
	        0x7F, 0x20, 0x18, 0x20, 0x7F,// W
	        0x63, 0x14, 0x08, 0x14, 0x63,// X
	        0x03, 0x04, 0x78, 0x04, 0x03,// Y
	        0x61, 0x51, 0x49, 0x45, 0x43,// Z
	        0x00, 0x00, 0x7F, 0x41, 0x41,// [
	        0x02, 0x04, 0x08, 0x10, 0x20,// "\"
	        0x41, 0x41, 0x7F, 0x00, 0x00,// ]
	        0x04, 0x02, 0x01, 0x02, 0x04,// ^
	        0x40, 0x40, 0x40, 0x40, 0x40,// _
	        0x00, 0x01, 0x02, 0x04, 0x00,// `
	        0x20, 0x54, 0x54, 0x54, 0x78,// a
	        0x7F, 0x48, 0x44, 0x44, 0x38,// b
	        0x38, 0x44, 0x44, 0x44, 0x20,// c
	        0x38, 0x44, 0x44, 0x48, 0x7F,// d
	        0x38, 0x54, 0x54, 0x54, 0x18,// e
	        0x08, 0x7E, 0x09, 0x01, 0x02,// f
	        0x08, 0x14, 0x54, 0x54, 0x3C,// g
	        0x7F, 0x08, 0x04, 0x04, 0x78,// h
	        0x00, 0x44, 0x7D, 0x40, 0x00,// i
	        0x20, 0x40, 0x44, 0x3D, 0x00,// j
	        0x00, 0x7F, 0x10, 0x28, 0x44,// k
	        0x00, 0x41, 0x7F, 0x40, 0x00,// l
	        0x7C, 0x04, 0x18, 0x04, 0x78,// m
	        0x7C, 0x08, 0x04, 0x04, 0x78,// n
	        0x38, 0x44, 0x44, 0x44, 0x38,// o
	        0x7C, 0x14, 0x14, 0x14, 0x08,// p
	        0x08, 0x14, 0x14, 0x18, 0x7C,// q
	        0x7C, 0x08, 0x04, 0x04, 0x08,// r
	        0x48, 0x54, 0x54, 0x54, 0x20,// s
	        0x04, 0x3F, 0x44, 0x40, 0x20,// t
	        0x3C, 0x40, 0x40, 0x20, 0x7C,// u
	        0x1C, 0x20, 0x40, 0x20, 0x1C,// v
	        0x3C, 0x40, 0x30, 0x40, 0x3C,// w
	        0x44, 0x28, 0x10, 0x28, 0x44,// x
	        0x0C, 0x50, 0x50, 0x50, 0x3C,// y
	        0x44, 0x64, 0x54, 0x4C, 0x44,// z
	        0x00, 0x08, 0x36, 0x41, 0x00,// {
	        0x00, 0x00, 0x7F, 0x00, 0x00,// |
	        0x00, 0x41, 0x36, 0x08, 0x00,// }
	        0x08, 0x08, 0x2A, 0x1C, 0x08,// ->
	        0x08, 0x1C, 0x2A, 0x08, 0x08 // <-
        };
        
        /*static int[] font = {
            0x00, 0x00, 0x00, 0x00, 0x00, // chr: ' '  (2 wide)
            0x5e, 0x00, 0x00, 0x00, 0x00, // chr: '!'  (1 wide)
            0x06, 0x00, 0x06, 0x00, 0x00, // chr: '"'  (3 wide)
            0x14, 0x3e, 0x14, 0x3e, 0x14, // chr: '#'  (5 wide)
            0x24, 0x2a, 0x7e, 0x2a, 0x12, // chr: '$'  (5 wide)
            0x44, 0x20, 0x10, 0x08, 0x44, // chr: '%'  (5 wide)
            0x34, 0x4a, 0x54, 0x20, 0x50, // chr: '&'  (5 wide)
            0x04, 0x02, 0x00, 0x00, 0x00, // chr: '''  (2 wide)
            0x3c, 0x42, 0x00, 0x00, 0x00, // chr: '('  (2 wide)
            0x42, 0x3c, 0x00, 0x00, 0x00, // chr: ')'  (2 wide)
            0x54, 0x38, 0x38, 0x54, 0x00, // chr: '*'  (4 wide)
            0x10, 0x38, 0x10, 0x00, 0x00, // chr: '+'  (3 wide)
            0x40, 0x20, 0x00, 0x00, 0x00, // chr: ','  (2 wide)
            0x10, 0x10, 0x10, 0x00, 0x00, // chr: '-'  (3 wide)
            0x40, 0x00, 0x00, 0x00, 0x00, // chr: '.'  (1 wide)
            0x40, 0x20, 0x10, 0x08, 0x04, // chr: '/'  (5 wide)
            0x3c, 0x52, 0x4a, 0x3c, 0x00, // chr: '0'  (4 wide)
            0x44, 0x7e, 0x40, 0x00, 0x00, // chr: '1'  (3 wide)
            0x64, 0x52, 0x4a, 0x44, 0x00, // chr: '2'  (4 wide)
            0x42, 0x4a, 0x4a, 0x34, 0x00, // chr: '3'  (4 wide)
            0x1e, 0x10, 0x7c, 0x10, 0x00, // chr: '4'  (4 wide)
            0x4e, 0x4a, 0x4a, 0x32, 0x00, // chr: '5'  (4 wide)
            0x3c, 0x4a, 0x4a, 0x32, 0x00, // chr: '6'  (4 wide)
            0x02, 0x72, 0x0a, 0x06, 0x00, // chr: '7'  (4 wide)
            0x34, 0x4a, 0x4a, 0x34, 0x00, // chr: '8'  (4 wide)
            0x0c, 0x52, 0x52, 0x3c, 0x00, // chr: '9'  (4 wide)
            0x24, 0x00, 0x00, 0x00, 0x00, // chr: ':'  (1 wide)
            0x40, 0x24, 0x00, 0x00, 0x00, // chr: ';'  (2 wide)
            0x10, 0x28, 0x44, 0x00, 0x00, // chr: '<'  (3 wide)
            0x28, 0x28, 0x28, 0x00, 0x00, // chr: '='  (3 wide)
            0x44, 0x28, 0x10, 0x00, 0x00, // chr: '>'  (3 wide)
            0x04, 0x52, 0x0a, 0x04, 0x00, // chr: '?'  (4 wide)
            0x38, 0x04, 0x34, 0x44, 0x38, // chr: '@'  (5 wide)
            0x7c, 0x12, 0x12, 0x7c, 0x00, // chr: 'A'  (4 wide)
            0x7e, 0x4a, 0x4a, 0x34, 0x00, // chr: 'B'  (4 wide)
            0x3c, 0x42, 0x42, 0x24, 0x00, // chr: 'C'  (4 wide)
            0x7e, 0x42, 0x42, 0x3c, 0x00, // chr: 'D'  (4 wide)
            0x7e, 0x4a, 0x4a, 0x42, 0x00, // chr: 'E'  (4 wide)
            0x7e, 0x0a, 0x0a, 0x02, 0x00, // chr: 'F'  (4 wide)
            0x3c, 0x42, 0x52, 0x34, 0x00, // chr: 'G'  (4 wide)
            0x7e, 0x08, 0x08, 0x7e, 0x00, // chr: 'H'  (4 wide)
            0x7e, 0x00, 0x00, 0x00, 0x00, // chr: 'I'  (1 wide)
            0x20, 0x40, 0x3e, 0x00, 0x00, // chr: 'J'  (3 wide)
            0x7e, 0x08, 0x14, 0x22, 0x40, // chr: 'K'  (5 wide)
            0x7e, 0x40, 0x40, 0x40, 0x00, // chr: 'L'  (4 wide)
            0x7e, 0x04, 0x08, 0x04, 0x7e, // chr: 'M'  (5 wide)
            0x7e, 0x04, 0x08, 0x10, 0x7e, // chr: 'N'  (5 wide)
            0x3c, 0x42, 0x42, 0x3c, 0x00, // chr: 'O'  (4 wide)
            0x7e, 0x12, 0x12, 0x0c, 0x00, // chr: 'P'  (4 wide)
            0x3c, 0x42, 0x22, 0x5c, 0x00, // chr: 'Q'  (4 wide)
            0x7e, 0x12, 0x32, 0x4c, 0x00, // chr: 'R'  (4 wide)
            0x24, 0x4a, 0x52, 0x24, 0x00, // chr: 'S'  (4 wide)
            0x02, 0x02, 0x7e, 0x02, 0x02, // chr: 'T'  (5 wide)
            0x3e, 0x40, 0x40, 0x3e, 0x00, // chr: 'U'  (4 wide)
            0x0e, 0x30, 0x40, 0x30, 0x0e, // chr: 'V'  (5 wide)
            0x3e, 0x40, 0x20, 0x40, 0x3e, // chr: 'W'  (5 wide)
            0x42, 0x24, 0x18, 0x24, 0x42, // chr: 'X'  (5 wide)
            0x06, 0x08, 0x70, 0x08, 0x06, // chr: 'Y'  (5 wide)
            0x62, 0x52, 0x4a, 0x46, 0x00, // chr: 'Z'  (4 wide)
            0x7e, 0x42, 0x00, 0x00, 0x00, // chr: '['  (2 wide)
            0x04, 0x08, 0x10, 0x20, 0x40, // chr: '\'  (5 wide)
            0x42, 0x7e, 0x00, 0x00, 0x00, // chr: ']'  (2 wide)
            0x04, 0x02, 0x04, 0x00, 0x00, // chr: '^'  (3 wide)
            0x40, 0x40, 0x40, 0x40, 0x00  // chr: '_'  (4 wide)
        };
        */



        public Form1()
        {
            InitializeComponent();

            System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\toto.txt");

            int i;
            
            for ( i = 0; i < 96; i++)
            {
                String text = "";

                for (int j = 0; j < 5; j++)
                {
                    int toto = 0;

                    toto += ((font[i * 5 + j] << 7) & 0x80);
                    toto += ((font[i * 5 + j] << 5) & 0x40);
                    toto += ((font[i * 5 + j] << 3) & 0x20);
                    toto += ((font[i * 5 + j] << 1) & 0x10);

                    toto += ((font[i * 5 + j] >> 1) & 0x08);
                    toto += ((font[i * 5 + j] >> 3) & 0x04);
                    toto += ((font[i * 5 + j] >> 5) & 0x02);
                    toto += ((font[i * 5 + j] >> 7) & 0x01);

                    toto = toto >> 1;

                    text = String.Format("{0} 0x{1:X2},", text, toto);
                }
                
                file.WriteLine(text);

            }

            file.Close();
        }
    }
}
