// See https://aka.ms/new-console-template for more information
static int[] RoundUp(int number, int[] list)
  {
    int[] arr = new int[2];
    if (list.Length == 0) return new int[0];
    bool single = true; 
    arr[0] = list[0];
    foreach(int i in list)
      {
        if (i == arr[0]) continue;
        if (Math.Abs(number - i) < Math.Abs(number - arr[0])) arr[0] = i;
        else if (Math.Abs(number - i) == Math.Abs(number - arr[0])) {arr[1] = i; single=false;}
      }
    if (single)
    {
      //int[] arr1 = {arr[0]};
      return arr[0].ToArray();
    }
    return arr;
  }
RoundUp(1, new int[] {-32,12,8,-10,-2});
