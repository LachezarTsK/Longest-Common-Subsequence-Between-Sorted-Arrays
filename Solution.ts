
function longestCommonSubsequence(arrays: number[][]): number[] {
    const RANGE_OF_VALUES: number[] = [1, 100];
    const frequency: number[] = new Array(RANGE_OF_VALUES[1] + 1).fill(0);
    const longestCommonSubsequence: number[] = new Array();

    for (let numbers of arrays) {
        for (let value of numbers) {
            ++frequency[value];
        }
    }

    for (let value = RANGE_OF_VALUES[0]; value <= RANGE_OF_VALUES[1]; value++) {
        if (frequency[value] === arrays.length) {
            longestCommonSubsequence.push(value);
        }
    }

    return longestCommonSubsequence;
};
