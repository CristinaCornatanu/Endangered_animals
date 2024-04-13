About: 
The purpose of the Endangered_animals project is to create a software 
application that provides users with information about endangered animals
and allows management of this information in a database.

Design pattern:

1. Repository Pattern:
This pattern is used in the implementation of the AnimalRepository, AlimentatieRepository, 
and CategorieSpecieRepository classes.
The Repository Pattern is employed to abstract the way data is accessed from the database. 
These classes provide methods to perform CRUD (Create, Read, Update, Delete) operations on
the respective entities, hiding the details of how the data is stored and retrieved.

3. Factory Pattern:
This pattern is used in the implementation of the IRepositoryFactory interface and the 
RepositoryFactory class.
The Factory Pattern is used to create objects without specifying the exact class of the
object to be created. In this case, RepositoryFactory is responsible for creating 
repository objects based on the specified type.

4. Observer Pattern:
This pattern is used in the implementation of the Subject class and the NotifyAll()
method in the RepositoryBase class.
The Observer Pattern is used to establish a one-to-many relationship between objects,
allowing changes in one object to automatically notify other objects that depend on them.
 In this case, Subject is notified when certain operations are performed on the repositories.
