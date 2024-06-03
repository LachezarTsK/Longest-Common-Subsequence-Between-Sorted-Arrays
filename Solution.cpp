
#include <array>
#include <vector>
using namespace std;

class Solution {

    static constexpr array<int, 2> RANGE_OF_VALUES = { 1, 100 };

public:
    vector<int> longestCommonSubsequence(const vector<vector<int>>& arrays) const {
        array<int, RANGE_OF_VALUES[1] + 1> frequency{};
        vector<int> longestCommonSubsequence;

        for (const auto& numbers : arrays) {
            for (int value : numbers) {
                ++frequency[value];
            }
        }

        for (size_t value = RANGE_OF_VALUES[0]; value <= RANGE_OF_VALUES[1]; value++) {
            if (frequency[value] == arrays.size()) {
                longestCommonSubsequence.push_back(value);
            }
        }

        return longestCommonSubsequence;
    }
};
