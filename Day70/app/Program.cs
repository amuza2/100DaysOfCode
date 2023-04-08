// See https://aka.ms/new-console-template for more information

void Palindrome(string value){
    bool pal = true;
    int odd = 0;
    int len = value.Length; 
    if(len % 2 == 1) odd = 1;
    for(int i = 0; i < len; i++){
        if(value[i] != value[len - 1 - i]){
            Console.WriteLine($"{value[i]} at index {i} != {value[len - 1]} at index {len - i - 1}");
            pal = false;
            break;
        }
        if(i == (len / 2) + odd) break;
    }
    if(pal == false) Console.WriteLine("It's not!");
    else Console.WriteLine("It is!");
    Console.WriteLine("----------------------");
}

Palindrome("mohammed");