﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace doix.Wpf.Controls.Properties
{
  using System;


  /// <summary>
  ///   A strongly-typed resource class, for looking up localized strings, etc.
  /// </summary>
  // This class was auto-generated by the StronglyTypedResourceBuilder
  // class via a tool like ResGen or Visual Studio.
  // To add or remove a member, edit your .ResX file then rerun ResGen
  // with the /str option, or rebuild your VS project.
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  internal class Resources
  {

    private static global::System.Resources.ResourceManager resourceMan;

    private static global::System.Globalization.CultureInfo resourceCulture;

    [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
    internal Resources()
    {
    }

    /// <summary>
    ///   Returns the cached ResourceManager instance used by this class.
    /// </summary>
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    internal static global::System.Resources.ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals(resourceMan, null))
        {
          global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("doix.Wpf.Controls.Properties.Resources", typeof(Resources).Assembly);
          resourceMan = temp;
        }
        return resourceMan;
      }
    }

    /// <summary>
    ///   Overrides the current thread's CurrentUICulture property for all
    ///   resource lookups using this strongly typed resource class.
    /// </summary>
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    internal static global::System.Globalization.CultureInfo Culture
    {
      get
      {
        return resourceCulture;
      }
      set
      {
        resourceCulture = value;
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to uniform sampler2D tex;
    ///
    /////in vec3 Color;
    ///
    ///varying vec4 var_color;
    ///
    ///void main()
    ///{
    ///    vec4 col = var_color * texture2D(tex, gl_TexCoord[0].st);// * gl_Color;
    ///	gl_FragColor = vec4(col.r, col.g, col.b, 1.0) * col.a; 
    ///	//gl_FragColor = var_color;
    ///}.
    /// </summary>
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    internal static string SimplePS
    {
      get
      {
        return ResourceManager.GetString("SimplePS", resourceCulture);
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to in vec3 Pos;
    ///in vec4 Color;
    ///in vec2 TexCoord;
    ///
    ///varying vec4 var_color;
    ///
    ///void main()
    ///{
    ///    gl_TexCoord[0] = vec4(TexCoord.x, TexCoord.y, 0, 0);//gl_MultiTexCoord0;
    ///    gl_Position = ftransform();
    ///	//gl_Position = gl_Vertex;
    ///	//gl_FrontColor = Color;
    ///
    ///	var_color = Color;
    ///}.
    /// </summary>
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    internal static string SimpleVS
    {
      get
      {
        return ResourceManager.GetString("SimpleVS", resourceCulture);
      }
    }

    /// <summary>
    ///   Looks up a localized resource of type System.Drawing.Bitmap.
    /// </summary>
    internal static System.Drawing.Bitmap white1x1
    {
      get
      {
        object obj = ResourceManager.GetObject("white1x1", resourceCulture);
        return ((System.Drawing.Bitmap)(obj));
      }
    }
  }
}
