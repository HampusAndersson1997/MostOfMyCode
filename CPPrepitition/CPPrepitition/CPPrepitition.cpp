#include <iostream>
#include <vector>
#include <algorithm>
#include <ctime>
#include <cstdlib>
class MainClass {
public:
    static std::vector<int> rarr;
    static std::vector<int> stat;
    static void generateRandomValues() {
        for (int& value : rarr) {
            value = rand() % 6 + 1 + rand() % 6 + 1 + rand() % 6 + 1;
        }
    }
    static void generateStats() {
        for (int value : rarr) {
            stat[value]++;
        }
    }
};
std::vector<int> MainClass::rarr(1000);
std::vector<int> MainClass::stat(19);
int main() {
    srand(static_cast<unsigned>(time(nullptr)));
    // 36.
    std::vector<std::string> strings = { "abra", "kadabra", "hokus", "pokus", "filiokus", "sim", "sala", "bim" };
    auto it = std::find(strings.begin(), strings.end(), "sim");
    if (it != strings.end()) {
        std::cout << "Index för 'sim' är: " << std::distance(strings.begin(), it) << "\n";
    }
    // 37.
    std::vector<int> arr1 = { 1, 5, 8, 4, 3, 7, 6, 2, 10, 9 };
    std::reverse(arr1.begin(), arr1.end());
    for (int val : arr1) {
        std::cout << val << " ";
    }
    std::cout << "\n";
    // 38.
    std::vector<int> arr2 = { 4, 4, 4, 4, 5, 6, 7, 5, 4, 3 };
    int count4 = std::count(arr2.begin(), arr2.end(), 4);
    int count5 = std::count(arr2.begin(), arr2.end(), 5);
    std::cout << "Antal 4:or: " << count4 << ", Antal 5:or: " << count5 << "\n";
    // 39.
    int sum = 0, product = 1;
    for (int val : arr2) {
        sum += val;
        product *= val;
    }
    std::cout << "Summa: " << sum << ", Produkt: " << product << "\n";
    // 40.
    std::vector<int> arr3(100);
    for (int i = 0; i < arr3.size(); i++) {
        arr3[i] = 100 - i;
        if (arr3[i] != arr3.size() - i) {
            std::cout << "Fel på index " << i << "!\n";
        }
    }
    // 41.
    std::vector<int> arr4 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    for (int i = 0; i < arr4.size() - 1; i++) {
        arr4[i] = arr4[i + 1];
    }
    for (int val : arr4) {
        std::cout << val << " ";
    }
    std::cout << "\n";
    // 42 & 43.
    MainClass::generateRandomValues();
    MainClass::generateStats();
    for (int i = 0; i < MainClass::stat.size(); i++) {
        std::cout << i << ": " << MainClass::stat[i] << "\n";
    }
    return 0;
}