using System;
using System.Collections.Generic;

public static class PesoLettere
{

    public static int Pesa(string input)
    {
     
        int peso = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if ( input[i] == 'a'||input[i] == 'A'||input[i]== 'e'||input[i] == 'E'||input[i] == 'i'||input[i] == 'I'||input[i] == 'o'||input[i] == 'O'||input[i] == 'u'||input[i] == 'U'||input[i] == 'l'||input[i] == 'L'||input[i] == 'n'||input[i] == 'N'||input[i] == 'r'||input[i] == 'R'||input[i] == 's'||input[i] == 'S'||input[i] == 't'||input[i] == 'T')
            {
                peso= peso +1;
            }
            else if( input[i] == 'd'||input[i] == 'D'||input[i]  == 'g'||input[i] == 'G')
            {
                peso = peso +2;
            }
            else if(input[i]  == 'b'||input[i] == 'B'||input[i]  == 'c'||input[i] == 'C'||input[i]  == 'm'||input[i] == 'M'||input[i]  == 'p'||input[i] == 'P')
            {
                peso =peso + 3;
            }
            else if (input[i]  == 'f' ||input[i] == 'F'|| input[i]  == 'h' ||input[i] == 'H'|| input[i]  == 'v' ||input[i] == 'V'|| input[i]  == 'w' ||input[i] == 'W'|| input[i]  == 'y'||input[i] == 'Y')
            {
                peso = peso +4;
            }
            else if( input[i]  == 'k' ||input[i] == 'K')
            {
                peso =peso + 5;
            }
            else if( input[i]  == 'j'||input[i] == 'J'||input[i]  == 'x'||input[i] == 'X')
            {
                peso = peso +8;
            }
            else if( input[i]  == 'q'||input[i] == 'Q'||input[i]  == 'z'||input[i] == 'Z')
            {
                peso =peso + 10;
            }

        }

        

        return peso;
    }
}