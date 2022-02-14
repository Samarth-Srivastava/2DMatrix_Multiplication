class Solution {
    public List<List<int>> solve(List<List<int>> A, List<List<int>> B) {
        int M = A.Count();
        int N_A = A[0].Count();
        int N_B = B.Count();
        int P = B[0].Count();
        
        List<List<int>> C = new List<List<int>>();
        for(int i = 0; i < M; i++){
            List<int> inner = new List<int>();
            for(int j = 0; j < P; j++){
                int sum  = 0;
                for(int k = 0; k < N_A; k++){
                    sum = sum + (A[i][k] * B[k][j]);
                }
                inner.Add(sum);
            }
            C.Add(inner);
        }


        return C;
    }
}
