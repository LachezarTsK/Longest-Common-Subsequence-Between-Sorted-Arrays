
package main

import "fmt"

var RANGE_OF_VALUES = [2]int{1, 100}

func longestCommonSubsequence(arrays [][]int) []int {
	var frequency = make([]int, RANGE_OF_VALUES[1]+1)
	var longestCommonSubsequence = []int{}

	for _, numbers := range arrays {
		for _, value := range numbers {
			frequency[value]++
		}
	}

	for value := RANGE_OF_VALUES[0]; value <= RANGE_OF_VALUES[1]; value++ {
		if frequency[value] == len(arrays) {
			longestCommonSubsequence = append(longestCommonSubsequence, value)
		}
	}

	return longestCommonSubsequence
}
