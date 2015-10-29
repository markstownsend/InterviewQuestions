
###Everyone who writes code
	
* Describe the difference between a Thread and a Process?  A process contains threads, not the other way round.  Threads share the address space in a process, processes do not share address space.
* What is a Windows Service and how does its lifecycle differ from a "standard" EXE?.  A Windows process can start, stop, pause and restart.  An exe starts and runs through to the logical end of the application.
* What is the maximum amount of memory any single process on Windows can address? 2 ^ 32 = 4GB but there's usually some reserved space that can't be used by the process and is used by the OS.  In .NET on Windows this is normally 2GB but can be reduced to 1GB.  So the normal answer is that on a 32 bit machine 2GB is usually addressable by any single process.  Is this different than the maximum virtual memory for the system? Yes, virtual memory includes temporary use of the hard disk.  How would this affect a system design?  Use of the hard disk will be slower than raw RAM access so it should be avoided in system design.
* What is the difference between an EXE and a DLL?  EXE gets its own process, DLL gets loaded in to an existing process.  EXE has only the module entry point exported, DLL has multiple exported symbols.  Although you can use LoadLibraryEx on an exe or a dll meaning exe can be dynamically linked too.  DLL is a shared library on the whole however and an EXE is not.  Purpose of DLL is to share/ re-use, purpose of EXE is to run its own application.
* What is strong-typing versus weak-typing?  Strong-typing means you can't use one type when another is expected.  Weak-typing means it is possible in some circumstances to interchange types.  .NET is strongly-typed, PHP is weakly-typed.  JavaScript is a dynamic language which is not the same as strong/ weak typing.  Which is preferred?  Depends.  Why?  On the whole strongly-typed languages remove a class of runtime errors by having the compiler check/ enforce type safety at compile type.
* Corillian's product is a "Component Container." Name at least 3 component containers that ship now with the Windows Server Family.  A component is a class that implements System.ComponentModel.IComponent or derives from a class that does.  A Control is a component with a UI.  A Component Container is a class that implements System.ComponentModel.IContainer interface or derives from a class that does.  The Container holds the components so it is easy to access the controls dynamically.
* What is a PID? Process ID,  an integer which uniquely identifies your process.  How is it useful when troubleshooting a system?  It is possible to get the PID from the code (System.Diagnostics) or from Process Explorer then you can see the resources the process is using.
* How many processes can listen on a single TCP/IP port? 1.
* What is the GAC? Global Assembly Cache.  Central location on machine to store .NET assemblies.  What problem does it solve?  Multiple versions of the same assembly on the same machine and their 'entanglement' (i.e. links to other multiple versions of assemblies etc. etc.).

    ###Mid-Level .NET Developer

	    Describe the difference between Interface-oriented, Object-oriented and Aspect-oriented programming.
* Describe what an Interface is and how it’s different from a Class.  A class is the base of an object hierarchy whereas an interface is outside that hierarchy.  An interface is an 'ability an object can have' where as a class is 'what an object is'.
* What is Reflection?  The ability to look inside a class and determine its members at runtime.  
        What is the difference between XML Web Services using ASMX and .NET Remoting using SOAP?
        Are the type system represented by XmlSchema and the CLS isomorphic?
        Conceptually, what is the difference between early-binding and late-binding?
        Is using Assembly.Load a static reference or dynamic reference?
        When would using Assembly.LoadFrom or Assembly.LoadFile be appropriate?
        What is an Asssembly Qualified Name? Is it a filename? How is it different?
        Is this valid? Assembly.Load("foo.dll");
* How is a strongly-named assembly different from one that isn’t strongly-named?  A strongly named assembly can only call other strongly named assemblies.
* Can DateTimes be null?  No.  DateTime is a value type.
* What is the JIT? Just in time compiler.  It compiles your IL to machine native code at runtime (method by method as they are called). What is NGEN? Native Generation is typically done at installation time and happens before the program is run.  It must be done on the same machine/ architecture and typically it means the assembly is loaded into the GAC.  NGEN code pages are shareable meaning that multiple application instances can share the same memory space as the first instance.  This can be efficient but it can lead to problems especially if you have multiple users using instances of your application on the same machine.  What are limitations and benefits of each?
* How does the generational garbage collector in the .NET CLR manage object lifetime? 3 generations: Gen0, Gen1 both memory bound when limit is breached GC is called.  If objects survive a collection they move to the next generation.  Gen2 is final generation where objects are longer lived.  Gen2 collection can be triggered manually otherwise it happens non-deterministically, when the managed runtime decides.  What is non-deterministic finalization?  Finalizers run on a separate thread.  Programmer has no control over when they run or in what order (of objedts).
* What is the difference between Finalize() and Dispose()?  Dispose is called by the developer either explicitly or by implementing IDisposable pattern and using statement.  In Dispose method can clean up resources held by other objects for example if object a holds a list<b> can clean up the b's in the Dispose method.  Finalize is called by the Finalizer thread.  If you put code in the Finalize method (~Classname) it must be discreet (i.e. not try to interact with other objects) and fast because you shouldn't cause an error on the Finalizer thread (this can crash your program) and you shouldn't tie it up with too much work because then it can't do its job of recovering memory.
* How is the using() pattern useful? Implicitly calls the Dispose method on your object.  What is IDisposable?  Interface to implement to deterministically clean up your objects.  How does it support deterministic finalization?  Well it doesn't support deterministic finalization.  Finalize and Dispose are different.  It supports deterministic cleaning up of the object.
* What does this useful command line do? tasklist /m "mscor*".  Lists all the tasks/ processes using the given exe/dll name.
* What is the difference between in-proc and out-of-proc?  In proc means something occurs in the same process, out-of-proc means it occurs in a separate process.  Crossing process boundaries involves (probable) additional actions like: authz, authn, serialization.
* What technology enables out-of-proc communication in .NET?  WCF
* When you’re running a component within ASP.NET, what process is it running within on Windows XP? Windows 2000? Windows 2003?  The IIS worker process w3wp.exe now.  It used to be aspnet_wp.exe.

    ###Senior Developers/Architects

* What’s wrong with a line like this? DateTime.Parse(myString);  It can throw an ArgumentNullException if myString is null and a FormatException if myString is not in a recognizable date format.  It also uses an implied IFormatProvider which represents the system's current culture and this may be different when run on different machines.
* What are PDBs? Program Database files.  They contain type and symbolic debug information gathered over the course of compiling and linking.  Where must they be located for debugging to work?  The Visual Studio
debugger uses the path to the PDB in the EXE or DLL file to find the project.pdb file. If the debugger cannot find the PDB file at that location, or if the path is invalid, for example, if the project was moved to another computer, the debugger searches the path containing the EXE followed by the symbol paths specified in the Options dialog box (Solution Properties-->Debug Symbol Files node in VS). The debugger will not load a PDB that does not match the binary being debugged. 
* What is cyclomatic complexity and why is it important?  A measure to describe the complexity of a piece of code.  A piece of code with a lot of branches will have a high cyclomatic complexity.  Also abstractions like LINQ and Reflection generate high cyclomatic complexity scores.
        Write a standard lock() plus “double check” to create a critical section around a variable access.
        What is FullTrust? Do GAC’ed assemblies have FullTrust?
* What benefit does your code receive if you decorate it with attributes demanding specific Security permissions? Prevents callers without those permissions from executing the code.
* What does this do? gacutil /l | find /i "Corillian"  Lists all the assemblies in the GAC then searches that list for "Corillian" in a case-insensitive manner.
* What does this do? sn -t foo.dll  Displays the token for the public key for foo.dll.
* What ports must be open for DCOM over a firewall? DCOM operates on a large range of ports (basically it is one port per process) so this can be any available range on the host server.  This is part of the problem with DCOM, the need to open so many ports on a machine and by exension on a firewall and allow pretty much any communication over those ports, it is insecure.  What is the purpose of Port 135?  Port 135 is the open port for the DCOM SCM (Service Control Manager) which tells the requestor which port in the range (1024 - 5000 by default) to use to connect to the hosted COM object.
        Contrast OOP and SOA. What are tenets of each?
        How does the XmlSerializer work? What ACL permissions does a process using it require?
* Why is catch(Exception) almost always a bad idea?  Catching an exception like this clears the exception stack trace so you lose all the context of the original exception.
        What is the difference between Debug.Write and Trace.Write? When should each be used?
        What is the difference between a Debug and Release build? Is there a significant speed difference? Why or why not?
        Does JITting occur per-assembly or per-method? How does this affect the working set?
* Contrast the use of an abstract base class against an interface?  Interface has no implementation, all methods are public, has no variables.  Abstract base class can have implementation, variables and non-public members.  Interface is an ability, abstract base class is a thing. 
        What is the difference between a.Equals(b) and a == b?
        In the context of a comparison, what is object identity versus object equivalence?
        How would one do a deep copy in .NET?
* Explain current thinking around IClonable.  You shouldn't implement the ICloneable interface on your classes because there is no agreement on whether the Clone method should perform a deep or shallow clone.
* What is boxing?  Convert a value type to a reference type.
* Is string a value type or a reference type?  string is an alias for String which is a reference type.  Although, == and != are overridden in string to perform value equality, not reference equality.
        What is the significance of the "PropertySpecified" pattern used by the XmlSerializer? What problem does it attempt to solve?
        Why are out parameters a bad idea in .NET? Are they?
        Can attributes be placed on specific parameters to a method? Why is this useful?
* What is a meant by a 'primitive type'?  A primitive type is one of the set of predefined value types in the Common Language Runtime.  Primitive types are so called because they are supported directly via instructions in compiled code, which usually translates to direct support on the underlying processor.  Of the numeric primitives, decimal is not a primitive type.
* What are all the bindings in WCF?
* How is polymorphism implemented in .NET?
* What is the difference between an interface and an abstract class?  When would you use either?
* What is the difference between new and override?
* Why should you not override a constructor typically?
* What is the visibility of a protected internal member?
* How does the garbage collector work?  What implications does this have for object instantiation in your code?
* Contrast the use of the Dispose method and the Finalize method.
* What are the differences between reference and value types.  When do you get reference type behaviour for value types?  String equivalence, value types on the heap?
* Contrast string and StringBuilder.
* What is a delegate?  When do you use it?  What particular problem does it solve?

    ### C# Component Developers

        Juxtapose the use of override with new. What is shadowing?
        Explain the use of virtual, sealed, override, and abstract.
        Explain the importance and use of each component of this string: Foo.Bar, Version=2.0.205.0, Culture=neutral, PublicKeyToken=593777ae2d274679d
        Explain the differences between public, protected, private and internal.
        What benefit do you get from using a Primary Interop Assembly (PIA)?
* By what mechanism does NUnit know what methods to test?  Test methods must be public and in a public class, the method must be identified by the attribute [Test] and the class identified by the attribute [TestFixture].
        What is the difference between: catch(Exception e){throw e;} and catch(Exception e){throw;}
        What is the difference between typeof(foo) and myFoo.GetType()?
        Explain what’s happening in the first constructor: public class c{ public c(string a) : this() {;}; public c() {;} } How is this construct useful?
* What is this? Language syntax referring to the current instance of a class.  Can this be used within a static method?  No.  Static method has no current instance.

    ### ASP.NET (UI) Developers

        Describe how a browser-based Form POST becomes a Server-Side event like Button1_OnClick...
        
###Database developers

* What is normalization?
* What is referential integrity?
* What are indexes?  What are they for?
* If you are the victim of a table lock how can you investigate who has the lock?  sp_who tells you who is on but it is privileged to.

