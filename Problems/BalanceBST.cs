using dsa.DataStructures;

namespace dsa.Problems
{
    public class BalanceBST {

        BST bst = new BST();   

        public BST Solve(int[] arr) {
            int N = arr.Length;
            CreateSubTree(arr, 0, N - 1);
            return bst;
        }

        private void CreateSubTree(int[] arr, int start, int end) {
            if(start > end)            
                return;       
            
            int mid = ((end - start) / 2 ) + start;
            bst.Insert(arr[mid]);
            CreateSubTree(arr, start, mid - 1);
            CreateSubTree(arr, mid + 1, end);        
        }        
    }
}
