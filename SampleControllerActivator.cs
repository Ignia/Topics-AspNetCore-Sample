/*==============================================================================================================================
| Author        Ignia, LLC
| Client        Ignia, LLC
| Project       Sample OnTopic Site
\=============================================================================================================================*/
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using OnTopicTest.Controllers;

namespace OnTopicTest {

  /*============================================================================================================================
  | CLASS: CONTROLLER ACTIVATOR
  \---------------------------------------------------------------------------------------------------------------------------*/
  /// <summary>
  ///   Responsible for creating instances of factories in response to web requests. Represents the Composition Root for
  ///   Dependency Injection.
  /// </summary>
  public class SampleControllerActivator : IControllerActivator {

    /*==========================================================================================================================
    | CONSTRUCTOR
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Establishes a new instance of the <see cref="SampleControllerFactory"/>, including any shared dependencies to be used
    ///   across instances of controllers.
    /// </summary>
    public SampleControllerActivator() {

    }

    /*==========================================================================================================================
    | METHOD: CREATE
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Registers dependencies, and injects them into new instances of controllers in response to each request.
    /// </summary>
    /// <returns>A concrete instance of an <see cref="IController"/>.</returns>
    public object Create(ControllerContext context) {

      /*------------------------------------------------------------------------------------------------------------------------
      | Determine controller type
      \-----------------------------------------------------------------------------------------------------------------------*/
      Type type = context.ActionDescriptor.ControllerTypeInfo.AsType();

      /*------------------------------------------------------------------------------------------------------------------------
      | Configure and return appropriate controller
      \-----------------------------------------------------------------------------------------------------------------------*/
      if (type == typeof(HomeController)) {
        return CreateHomeController();
      }
      else {
        throw new Exception($"Unknown controller {type.Name}");
      }

    }

    /*==========================================================================================================================
    | METHOD: CREATE HOME CONTROLLER
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Responds to a request to create a <see cref="HomeController"/> instance, the default controller for the site.
    /// </summary>
    private HomeController CreateHomeController() {

      /*------------------------------------------------------------------------------------------------------------------------
      | Return HomeController
      \-----------------------------------------------------------------------------------------------------------------------*/
      return new HomeController();

    }

    /*==========================================================================================================================
    | METHOD: RELEASE
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Responds to a request to release resources associated with a particular controller.
    /// </summary>
    public void Release(ControllerContext context, object controller) {

    }

  } //Class
} //Namespace