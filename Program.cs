// Top level statements
// Test solution 
// Example array, index triplet (0, 2, 4) is triangular
int[] arr_a = {10, 2, 5, 1, 8, 20};
int[] arr_b = {10, 50, 5, 1};
Console.WriteLine($"Test array [10, 2, 5, 1, 8, 20] is triangular: {IsTriangular(arr_a)}");
Console.WriteLine($"Test array [10, 50, 5, 1] is triangular: {IsTriangular(arr_b)}");

public static partial class Program {
    /// <summary>
    /// Solution to determining if a triplet (P, Q, R) satisfying 
    /// 0 <= P < Q < R < N whereby A[P], A[Q], A[R] is triangular 
    /// exists in array A of N integers. 
    /// Triangular means that the sum of any two elements of the triplet
    /// is larger than the value of the third element. 
    /// This solution sorts the array ascending and then moves a sliding 
    /// window over the elements from index i to i+2
    /// When a[i] + a[i + 1] > a[i + 2] the triangular condition is satisfied 
    /// as a[i], a[i+1] are the smallest elements of the triplet 
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public static bool IsTriangular(int[] arr) {
        // First QuickSort ascending 
        Array.Sort(arr); 

        // Iterate the array elements in a window i, i+1, i+2 
        // If the condition arr[i] + arr[i+1] > arr[i+1] is satisfied 
        // then the triplet must be triangular 
        // Because arr[i] <= arr[i+1] <= arr[i+2]
        for (int i = 0; i < (arr.Length - 2); i++) {
            if ((arr[i] + arr[i + 1]) > arr[i + 2])
                return true;
        }

        return false;
    }
}