#include <stdio.h>
#include <stdlib.h>

int main()
{
    char type = ' ';
    int lung_passw ,temp = 0;
    srand(time(0));

    printf("How long do you want the password to be ");
    scanf("%d",&lung_passw);

    scanf("%c",&type);

    printf("You want only [c]arracters, [n]umber e carracters, [s]ymbols numbers and carracters ");
    scanf("%c",&type);

    char password[lung_passw];

    if(type == 'c'){
        for (int i = 0; i < lung_passw; i++)
        {
            if (((rand() % (2 + (0 * -1))) + 0) == 1)
            {
                password[i] = ((rand() % (91 + (65 * -1))) + 65);
            }
            else
            {
                password[i] = ((rand() % (123 + (97 * -1))) + 97);
            }
        }
    } else if(type == 'n'){
        for (int i = 0; i < lung_passw; i++)
        {
            if (((rand() % (3 + (0 * -1))) + 0) == 0)
            {
                password[i] = ((rand() % (91 + (65 * -1))) + 65);
            }
            else if (temp == 1)
            {
                password[i] = ((rand() % (123 + (97 * -1))) + 97);
            }
            else
            {
                password[i] = ((rand() % (58 + (48 * -1))) + 48);
            }
        }
    } else if(type = 's'){
        for (int i = 0; i < lung_passw; i++)
        {
            if (((rand() % (7 + (0 * -1))) + 0) == 0)
            {
                password[i] = ((rand() % (91 + (65 * -1))) + 65);
            }
            else if (temp == 1)
            {
                password[i] = ((rand() % (123 + (97 * -1))) + 97);
            }
            else if (temp == 2)
            {
                password[i] = ((rand() % (58 + (48 * -1))) + 48);
            }
            else if (temp == 3)
            {
                password[i] = ((rand() % (48 + (33 * -1))) + 33);
            }
            else if (temp == 4)
            {
                password[i] = ((rand() % (64 + (58 * -1))) + 58);
            }
            else if (temp == 5)
            {
                password[i] = ((rand() % (97 + (91 * -1))) + 91);
            }
            else if (temp == 6)
            {
                password[i] = ((rand() % (127 + (123 * -1))) + 123);
            }
        }
    } else{
        printf("The type entered isn't a valid one");
    }


    //Prints the password
    for(int i = 0; i < lung_passw; i++){
        printf("%c",password[i]);
    }
}
