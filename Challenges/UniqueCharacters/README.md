# Unique Characters
Use hashtable properties to find if there are repeated values.

## Challenge
Write a function that will determine if a given string is full of unique characters.

## Approach & Efficiency
Create a hashtable. Iterate through each character disregarding spaces and capitalization.  Check is the hashtable contains the character.  If it does, return false.  Otherwise, add it to thte hashtable.

- ### Time: O(n) <br>
- ### Space: O(n)

## Solution
![uniquecharacters](https://user-images.githubusercontent.com/25948479/48668165-d5a52300-ea9b-11e8-8195-61af9e17ad08.jpg)