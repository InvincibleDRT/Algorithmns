def string_reverser(our_string):

    """
    Reverse the input string

    Args:
       our_string(string): String to be reversed
    Returns:
       string: The reversed string
    """
    
    # TODO: Write your solution here
    
    rv_string =""
    for i in range(0,len(our_string)):
        rv_string += our_string[len(our_string)-i-1]
    return rv_string
    
# print ("Pass" if ('retaw' == string_reverser('water')) else "Fail")
# print ("Pass" if ('!noitalupinam gnirts gnicitcarP' == string_reverser('Practicing string manipulation!')) else "Fail")
# print ("Pass" if ('3432 :si edoc esuoh ehT' == string_reverser('The house code is: 2343')) else "Fail")


def anagram_checker(str1, str2):

    """
    Check if the input strings are anagrams of each other

    Args:
       str1(string),str2(string): Strings to be checked
    Returns:
       bool: Indicates whether strings are anagrams
    """
    charDistribution1 ={}
    charDistribution2 ={}
    for i in str1.lower():
        if i==" ":
            continue
        if charDistribution1.get(i)==None:
            charDistribution1[i]=0
        charDistribution1[i]+=1
    for i in str2.lower():
        if i==" ":
            continue
        if charDistribution2.get(i)==None:
            charDistribution2[i]=0
        charDistribution2[i]+=1
    for char in charDistribution1:
        if charDistribution1.get(char) != charDistribution2.get(char):
            return False
    for char in charDistribution2:
        if charDistribution1.get(char) != charDistribution2.get(char):
            return False
    
    return True

# print ("Pass" if not (anagram_checker('water','waiter')) else "Fail")
# print ("Pass" if anagram_checker('Dormitory','Dirty room') else "Fail")
# print ("Pass" if anagram_checker('Slot machines', 'Cash lost in me') else "Fail")
# print ("Pass" if not (anagram_checker('A gentleman','Elegant men')) else "Fail")
# print ("Pass" if anagram_checker('Time and tide wait for no man','Notified madman into water') else "Fail")


def word_flipper(our_string):

    """
    Flip the individual words in a sentence

    Args:
       our_string(string): String with words to flip
    Returns:
       string: String with words flipped
    """
    
    # TODO: Write your solution here
    flip=""
    substr= our_string.split(' ')
    index =0
    for i in substr:
        flip += string_reverser(i)
        if(len(substr)>1 and index < len(substr)-1):
            flip+=" "
        index+=1
    
    return flip


# Test Cases

print ("Pass" if ('retaw' == word_flipper('water')) else "Fail")
print ("Pass" if ('sihT si na elpmaxe' == word_flipper('This is an example')) else "Fail")
print ("Pass" if ('sihT si eno llams pets rof ...' == word_flipper('This is one small step for ...')) else "Fail")