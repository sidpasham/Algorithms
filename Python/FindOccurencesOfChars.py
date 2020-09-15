test_str ="asdasdasdasdas"
output = ""
for c in test_str:
    if c not in output:
        counter = test_str.count(c)
        output = output + c + str(counter)

print(output)