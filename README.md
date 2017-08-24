# kata-bloom-filter
# Joel T. Norman joel.t.norman@gmail.com

#Notes:
#This is a simple implementation using some TDD without stories.
#I started with the intent to use DI - but quickly backed away from DI due to the overhead costs (execution speed/time)

#The Bloom Filter implemented uses a salted/offset value in place of 3 different hash methods - which I believe gives the same result.

#Tests were derived from a state table drawn in my note book.

#In all reality, a bloomfilter should be as fast as possible, therefore, my implementation could be improved.

#How To
#1. Clone the Repo
#2. Open the Solution
#3. Run the Tests