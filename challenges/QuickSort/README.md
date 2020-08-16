# Code Challenge: Quick Sort

# Challenge Summary
After reviewing the pseudocode, trace the algorithm by stepping through the process with the provided sample array. Document your experience by creating a blog article that shows the step-by-step output after each iteration through some sort of visual.

Once you are done with your article, code a working, tested implementation of Insertion Sort based on the pseudocode provided.

## Challenge Description
When presented with a list of numbers you want to sort through, the proper way to perform a quick sort algorithm is broken up into these steps:
- Select the last element in the list (this becomes our "pivot element")
- Every element with a lesser OR equal value to the pivot goes on the left side
- Every element with a greater value to the pivot goes on the right side
- After the first iteration, you choose the element that is in the last position for each of the sublists and then do it again.
- Perform this operation until you have separated each element into its own level
- When all of the elements have been separated, stack them all up in the order they are now in and you should have a sorted list

## Approach & Efficiency
The approach was to break down all of the steps necessary and document them one by one in a blog article (featured in BLOG.md). After the blog post, I then went through and implemented the actual code.

## Solution