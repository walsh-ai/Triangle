An array A consisting of N integers is given (may be zero or negative). 

The triplet (P, Q, R) is triangular if 0 <= P < R < N and:
	A[P] + A[Q] > A[R]
	A[Q] + A[R] > A[P]
	A[R] + A[P] > A[Q]

Write a function that given the array A returns 1/true if there exists a triangular triplet and zero/false otherwise.

