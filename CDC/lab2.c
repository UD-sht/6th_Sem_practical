// WAP to check whether the string is constant or not.

#include<stdio.h>
#include<string.h>

int main()
{
    char msg[500];
    int i;
    printf("Enter the string: ");
    scanf("%s",msg);
    for(i=0;i<strlen(msg);i++)
    {
        if(msg[i]>48 && msg[i]<57)
        {
            printf("The %s is constant string.\n",msg);
            return 0;
        }
    }
    printf("The %s is not constant string.\n",msg);
    return 0;
}