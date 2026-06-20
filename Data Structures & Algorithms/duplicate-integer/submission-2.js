class Solution {
    /**
     * @param {number[]} nums
     * @return {boolean}
     */
    hasDuplicate(nums) {
        var nonDuplicates = new Set(nums);
        return nums.length !== nonDuplicates.size
    }
}
