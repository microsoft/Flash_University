#include <fstream>
#include <iostream>
using namespace std;

void printMatrix(int (*matrix)[100], int numRows, int numCols) {
  for (int i = 0; i < numRows; i++) {
    for (int j = 0; j < numCols; j++) {
      std::cout << matrix[i][j] << " ";
    }
    std::cout << std::endl;
  }
}

int findLargestPathSum(int (*matrix)[100]) {
  int maxVal = 0;
  for (int i = 1; i < 100; i++) {
    for (int j = 0; j <= i; j++) {
      if (j != 0) {
        matrix[i][j] =
            max(matrix[i - 1][j], matrix[i - 1][j - 1]) + matrix[i][j];
      } else {
        matrix[i][j] += matrix[i - 1][j];
      }
      maxVal = max(matrix[i][j], maxVal);
    }
  }
  return maxVal;
}

// a[i][j] = max(a[i-1][j], a[i-1][j-1]) + a[i][j]

int main() {
  std::ifstream file("triangle.txt"); // Open the file for reading
  int num;

  int values[100][100] = {{0}};

  int rowNumber = 0;
  int counter = 0;
  while (file >>
         num) // Read integers from the file until there's nothing left to read
  {
    // Do something with the integer
    if (counter <= rowNumber) {
      values[rowNumber][counter] = num;
    } else {
      counter = 0;
      rowNumber++;
      values[rowNumber][counter] = num;
    }
    counter++;
  }

  file.close(); // Close the file when we're done reading

  // printMatrix(values, 100, 100);

  std::cout << findLargestPathSum(values);
  return 0;
}
