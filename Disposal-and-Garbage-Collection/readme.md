Date 26-07-23
Tag: #bootcamp #syllabus #gc

---

# Garbage Collection Explanation
Garbage collection is a feature provided by the CLR (Common Language Runtime) that is used to clean up unused managed objects and release memory, enabling automatic memory management.
It runs on a background process thread and only cleans up managed memory.

### Memory Type
##### Managed Data
The managed data will be under control of the Garbage Collection, such as objects, variables, and static data.

##### Unmanaged Data
The unmanaged data will not be under control of Garbage Collection, so make sure to clean it because it will take memory spaces.
Unmanaged data includes FileStream, File, Network, Database, or other types that have connections to external programs.

### How the Garbage Collection Works
It consists of two phases: Mark and Sweep.
- In the Mark phase, it marks all the reachable data, including static and stack variables.
- In the Sweep phase, it sweeps all the unmarked variables, identifying them as garbage.

### Generation
There will be called **Heap Pointer**, it will be used for mark and sweep for every generation.
- Generation 0: Used to mark and sweep the newest or most recently created **objects**.
- Generation 1: Used to save the survivalist object from Generation 0. In a while, the Generation 1 will be full, so it will do mark and sweep.
- Generation 2: Used to save the most long-lived objects.

### Workstation and Server GC
GC will be run on separate thread, so when the GC kicks in, it will make the system halt for a while.
In the Server, that have more bigger resource, it will make the GC thread have more priority.
But in the Workstation, the GC and main thread will be have same priority.

### Destructor
It is also called Finalizer and is used for the necessary clean-up of an instance of a class.
The GC automatically calls the destructor when the object is being destroyed.

Destructor or FInalizers will make slow down to your computer, so, avoid using it. Better use the default GC process for managed resources, and use Dispose pattern for unmanaged resource.