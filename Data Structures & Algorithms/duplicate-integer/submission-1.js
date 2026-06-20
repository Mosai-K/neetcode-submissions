class Solution {
    /**
     * @param {number[]} nums
     * @return {boolean}
     */
    hasDuplicate(nums) {
        var seen = [];
        
        for (var i of nums) {
            if (seen.includes(i)) return true;
            seen.push(i);
        };
        return false;
    }
}
