﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityLibrary.RSA
{
    public class RSA
    {
        AES.ExtendedEuclid inverse = new AES.ExtendedEuclid();
        public int Encrypt(int p, int q, int M, int e)
        {
            int result ;
            int n = p * q;
            
            result = HelperFunctions.fastPower(M,e,n); 

            return result;

        }

        public int Decrypt(int p, int q, int C, int e)
        {
            int  result ;
            int  n = p * q;
            int Qn =(p-1)*(q-1);

            int d = inverse.GetMultiplicativeInverse(e, Qn);

             result = HelperFunctions.fastPower(C, d, n);


            return result;
        }
    }
}
