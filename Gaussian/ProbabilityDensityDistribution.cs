// -------------------------------------------------------------------------------------------------
// Name of Class: ProbabilityDensityDistribution
//
// Author: Ken Boorom
//
// Release Date: June 29, 2017
//
// Purpose: Stores a probability density distribution of an arbitrary numer of elements and adds
// new events to it.
//
// Usage Example:
//
//      var myPdf = new ProbabilityDensityDistribution(10);
//      var listOfSamples = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
//      myPdf.AddDistribution(listOfSamples);
//      myPdf.AddDistribution(new int[10] {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1};
//
//      myPdf.pdf[] now equals {2, 3, 4, 5, 6, 7, 8, 9, 10, 11}
//
// -------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaussian
{
    public class ProbabilityDensityDistribution
    {
        public double[] pdf;
        public int maxNumberAllowed;

        public ProbabilityDensityDistribution(int passedMaxNumberAllowed)
        {
            maxNumberAllowed = passedMaxNumberAllowed;
            pdf = new double[maxNumberAllowed + 1];
            for (int i = 0; i < maxNumberAllowed; i++)
                pdf[i] = 0;
        }


        public void AddDistribution(int[] myListOfSamples)
        {
            for (int n = 0; n < myListOfSamples.Length; n++)
            {
                int oneSample = myListOfSamples[n];
                if (oneSample < 0) throw new ArgumentException("Method does not allow negative numbers");
                if (oneSample > maxNumberAllowed) throw new ArgumentException("Passed a number exceeding maximum allowed");
                pdf[oneSample]++;
            }
        }

    }
}
