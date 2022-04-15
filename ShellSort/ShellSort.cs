namespace ShellSort;

public class ShellSort
{
    public int[] Sort(int[] givenArray)
    {
        int arrLen = givenArray.Length;
        int gap = arrLen / 2;
        while (gap != -1)
        {
            int left = 0;
            int right = gap;
            for (int i = 0; i < arrLen - gap; i++)
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

            if (gap != 1)
            {
                gap /= 2;
            }
            else
            {
                gap = -1;
            }
        }

        return givenArray;
    }
}