#include <stdio.h>
#include <stdlib.h>
#include <time.h>
// 36
void findSim() {
    char* strings[] = { "abra", "kadabra", "hokus", "pokus", "filiokus", "sim", "sala", "bim" };
    for (int i = 0; i < 8; i++) {
        if (strcmp(strings[i], "sim") == 0) {
            printf("Index för 'sim' är: %d\n", i);
            break;
        }
    }
}
// 37
void printReversed() {
    int arr[] = { 1, 5, 8, 4, 3, 7, 6, 2, 10, 9 };
    for (int i = 9; i >= 0; i--) {
        printf("%d ", arr[i]);
    }
    printf("\n");
}
// 38 & 39
void countAndSumProduct() {
    int arr[] = { 4, 4, 4, 4, 5, 6, 7, 5, 4, 3 };
    int count4 = 0, count5 = 0, sum = 0, product = 1;
    for (int i = 0; i < 10; i++) {
        if (arr[i] == 4) count4++;
        if (arr[i] == 5) count5++;
        sum += arr[i];
        product *= arr[i];
    }
    printf("Antal 4:or: %d\n", count4);
    printf("Antal 5:or: %d\n", count5);
    printf("Summa: %d\n", sum);
    printf("Produkt: %d\n", product);
}
// 40
void testArray() {
    int arr[100];
    for (int i = 0; i < 100; i++) {
        arr[i] = 100 - i;
        if (arr[i] != 100 - i) {
            printf("Fel på index %d!\n", i);
        }
    }
}
// 41
void shiftAndPrint() {
    int arr[10];
    for (int i = 0; i < 10; i++) {
        arr[i] = i;
    }
    for (int i = 0; i < 9; i++) {
        arr[i] = arr[i + 1];
    }
    for (int i = 0; i < 10; i++) {
        printf("%d ", arr[i]);
    }
    printf("\n");
}
// 42 & 43
void generateStatistics() {
    int rarr[1000];
    int stat[19] = { 0 };
    // Seed random
    srand(time(0));
    // Generate rarr values
    for (int i = 0; i < 1000; i++) {
        rarr[i] = rand() % 6 + 1 + rand() % 6 + 1 + rand() % 6 + 1;
        stat[rarr[i]]++;
    }
    // Print statistics
    for (int i = 0; i < 19; i++) {
        printf("%d: %d\n", i, stat[i]);
    }
}
int main() {
    findSim();
    printReversed();
    countAndSumProduct();
    testArray();
    shiftAndPrint();
    generateStatistics();
    return 0;
}