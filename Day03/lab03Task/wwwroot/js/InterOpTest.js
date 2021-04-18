function GenerateRandumInt() {
    DotNet.invokeMethodAsync('lab03Task', 'getRandumNum').then(result => alert(result))
}