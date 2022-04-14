using System;

namespace ShellSort{
    class ShellSort
    {
        public Array Sort(int[] givenArray)
        {
            int arrLen = givenArray.Length;
            int gap = arrLen / 2;
            while (gap != 1)
            {
                int left = 0;
                int right = gap;
                for (int i = 0; i < gap; i++)
                {
                    if (givenArray[left] > givenArray[right])
                    {
                        int lHolder = givenArray[left];
                        int rHolder = givenArray[right];
                        givenArray[left] = rHolder;
                        givenArray[right] = lHolder;
                    }

                    left++;
                    right++;
                }

                gap /= 2;
            }
            
        }
    }
}
