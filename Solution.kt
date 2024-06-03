
class Solution {

    private companion object {
        val RANGE_OF_VALUES = intArrayOf(1, 100)
    }

    fun longestCommonSubsequence(arrays: Array<IntArray>): List<Int> {
        val frequency = IntArray(RANGE_OF_VALUES[1] + 1)
        val longestCommonSubsequence = ArrayList<Int>()

        for (numbers in arrays) {
            for (value in numbers) {
                ++frequency[value]
            }
        }

        for (value in RANGE_OF_VALUES[0]..RANGE_OF_VALUES[1]) {
            if (frequency[value] == arrays.size) {
                longestCommonSubsequence.add(value)
            }
        }

        return longestCommonSubsequence
    }
}
