//WAP to count the number of lines and spaces in the input strings.

#include<stdio.h>
#include<string.h>

int main()
{
    char msg[500];
    int i,line=1,space=0;
    printf("Enter the string for the message: \n");
    scanf("%[^\t]",msg);
    for(i=0;i<strlen(msg);i++)
    {
        if(msg[i]==' ')
        {
            space++;
        }
        if(msg[i]=='\n')
        {
            line++;
        }
    }
    printf("\nNumber of lines: %d\nNumber of spaces: %d\n",line,space);
    return 0;
}