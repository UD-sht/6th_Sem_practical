// WAP to check whether the string is keyword or not.

#include <stdio.h>
#include <string.h>

int main()
{
    char keyword[32][15] = {"auto", "double", "int", "struct", "break", "else", "long",

                            "switch", "case", "enum", "register", "typedef", "char",

                            "extern", "return", "union", "const", "float", "short",

                            "unsigned", "continue", "for", "signed", "void", "default",

                            "goto", "sizeof", "voltile", "do", "if", "static", "while"};
    char str[15];
    int i;
    printf("Enter the string: ");
    scanf("%s", str);
    for (i = 0; i < 32; i++)
    {
        if (strcmp(keyword[i], str) == 0)   
        {
            printf("The %s is keyword.\n", str);
            return 0;
        }
    }
    printf("The %s is not keyword.\n", str);
    return 0;
}