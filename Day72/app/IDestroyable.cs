using System;

namespace Learning;

interface IDestroyable
{
    string DestructionSound {get; set;}
    void Destroy();
}