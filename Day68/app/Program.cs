// See https://aka.ms/new-console-template for more information
static int[] RoundUp(int number, int[] list)
  {
    int[] arr = new int[2];
    arr[0] = list[0];
    foreach(int i in list)
      {
        if (i == arr[0]) continue;
        if (Math.Abs(number - i) < Math.Abs(number - list[0])) list[0] = i;
        else if (Math.Abs(number - i) == Math.Abs(number - list[0])) list[1] = i;
      }
    return arr;
  }
int[] r = RoundUp(10, new int[] {1,2,3,4,6,12});
foreach(int i in r) Console.WriteLine(i);