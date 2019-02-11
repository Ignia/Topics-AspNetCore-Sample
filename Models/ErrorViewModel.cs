/*==============================================================================================================================
| Author        Ignia, LLC
| Client        Ignia, LLC
| Project       Sample OnTopic Site
\=============================================================================================================================*/
using System;

namespace OnTopicTest.Models {

  /*============================================================================================================================
  | CLASS: ERROR VIEW MODEL
  \---------------------------------------------------------------------------------------------------------------------------*/
  /// <summary>
  ///   Represents the view state for an error page. Associated with <c>Error.cshtml</c>.
  /// </summary>
  public class ErrorViewModel {

    /*==========================================================================================================================
    | PROPERTY: REQUEST ID
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Represents the current <see cref="Activity"/> identifier or, if unavailable, the <see cref="HttpContext"/>'s
    ///   <c>TraceIdentifier</c>.
    /// </summary>
    public string RequestId { get; set; }

    /*==========================================================================================================================
    | PROPERTY: SHOW REQUEST ID
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Determines whether or not the <see cref="RequestId"/> should be displayed; defauls to false if the <see
    ///   cref="RequestId"/> value is not set.
    /// </summary>
    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

  } //Class
} //Namespace