/*==============================================================================================================================
| Author        Ignia, LLC
| Client        Ignia, LLC
| Project       Sample OnTopic Site
\=============================================================================================================================*/
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnTopicTest.Models;

namespace OnTopicTest.Controllers {

  /*============================================================================================================================
  | CLASS: HOME CONTROLLER
  \---------------------------------------------------------------------------------------------------------------------------*/
  /// <summary>
  ///   Represents the default <see cref="Controller"/> for the web application.
  /// </summary>
  public class HomeController : Controller {

    /*==========================================================================================================================
    | ACTION: INDEX
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   The default action for incoming requests. Produces the homepage of the site.
    /// </summary>
    public IActionResult Index() {
      return View();
    }

    /*==========================================================================================================================
    | ACTION: PRIVACY
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Produces the privacy statement for the site.
    /// </summary>
    public IActionResult Privacy() {
      return View();
    }

    /*==========================================================================================================================
    | ACTION: ERROR
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Produces the error page for the site using an <see cref="ErrorViewModel"/>.
    /// </summary>
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

  } //Class
} //Namespace