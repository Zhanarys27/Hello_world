int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 >= result) result=arg2;
    if(arg3 >= result) result=arg3;
    return result;
}

int a1 = 23, b1 = 21, c1 = 42,
    a2 = 54, b2 = 76, c2 = 45,
    a3 = 34, b3 = 67, c3 = 89;


Console.WriteLine(Max(Max(a1,b1,c1), Max(a2,b2,c2), Max(a3,b3,c3)));