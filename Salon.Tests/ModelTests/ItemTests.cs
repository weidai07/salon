using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Salon.Models;
using System;
using MySql.Data.MySqlClient;

namespace Salon.Tests
{
  [TestClass]
  public class ClientTest : IDisposable
  {

    public void Dispose()
    {
      Client.ClearAll();
    }

    public ClientTest()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=epicodus;port=3306;database=salon_test;";
    }

    [TestMethod]
    public void ClientConstructor_CreatesInstanceOfClient_Client()
    {
      Client newClient = new Client("test");
      Assert.AreEqual(typeof(Client), newClient.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "Walk the dog.";

      //Act
      Client newClient = new Client(description);
      string result = newClient.Description;

      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string description = "Walk the dog.";
      Client newClient = new Client(description);

      //Act
      string updatedDescription = "Do the dishes";
      newClient.Description = updatedDescription;
      string result = newClient.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyListFromDataBase_ClientList()
    {
      // Arrange
      List<Client> newList = new List<Client> { };

      // Act
      List<Client> result = Client.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsClients_ClientList()
    {
      //Arrange
      string description01 = "Walk the dog";
      string description02 = "Wash the dishes";
      Client newClient1 = new Client(description01);
      newClient1.Save();
      Client newClient2 = new Client(description02);
      newClient2.Save();
      List<Client> newList = new List<Client> { newClient1, newClient2 };

      //Act
      List<Client> result = Client.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
      public void GetId_ClientsInstantiateWithAnIdAndGetterReturns_Int()
      {
        //Arrange
        string description = "Walk the dog.";
        Client newClient = new Client(description);

        //Act
        int result = newClient.Id;

        //Assert
        Assert.AreEqual(1, result);
      }
    [TestMethod]
      public void Find_ReturnsCorrectClientFromDatabase_Client()
      {
        //Arrange
        Client newClient = new Client ("Mow the lawn");
        newClient.Save();
        Client newClient2 = new Client ("Wash dishes");
        newClient2.Save();

        //Act
        Client foundClient = Client.Find(newClient.Id);

        //Assert
        Assert.AreEqual(newClient, foundClient);
      }
    [TestMethod]
      public void Equals_ReturnsTrueIfDescriptionsAreTheSame_Client()
      {
        // Arrange, Act
        Client firstClient = new Client("Mow the lawn");
        Client secondClient = new Client("Mow the lawn");

        // Assert
        Assert.AreEqual(firstClient, secondClient);
      }
  }
}