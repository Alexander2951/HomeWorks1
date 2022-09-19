int[,] table=new int[4,4];
int layer=0;
int count=1;
while(count<16)
{
    for(int i=(0+layer);i<(table.GetLength(1)-layer);i++)
    {
        table[(0+layer),i]=count;
        count++;
        if(count>16) break;
    }
    for(int j=(1+layer); j<(table.GetLength(0)-layer);j++)
    {
        table[j,(table.GetLength(1)-1-layer)]=count;
        count++;
        if(count>16) break;
    }
    for(int k=(table.GetLength(1)-2-layer);k>0+layer;k--)
    {
        table[table.GetLength(0)-1-layer,k]=count;
        count++;
        if(count>16) break;
    }
    for(int l=(table.GetLength(0)-1-layer);l>=(1+layer);l--)
    {
        table[l,(0+layer)]=count;
        count++;
        if(count>16) break;
    }
    layer+=1;
}
void PrintArr()
{
    for (int i=0;i<table.GetLength(0);i++)
    {
        for(int j=0;j<table.GetLength(1);j++)
        {
            Console.Write ($"{table[i,j]} \t");
        }
        Console.WriteLine();
    }
}
PrintArr();