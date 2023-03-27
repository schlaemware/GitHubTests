// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace PackagedTestApp {
  /// <summary>
  /// An empty window that can be used on its own or navigated to within a Frame.
  /// </summary>
  public sealed partial class MainWindow: Window {
    public MainWindow() {
      this.InitializeComponent();
    }

    private void myButton_Click(object sender, RoutedEventArgs e) {
      myButton.Content = "Clicked";
      AssemblyVersionTextBlock.Text = $"Assembly version: {Assembly.GetExecutingAssembly().GetName().Version}";
      PackageVersionTextBlock.Text = $"Package version: {GetAppVersion()}";
    }

    private static Version GetAppVersion() {
      Package package = Package.Current;
      PackageVersion version = package.Id.Version;

      return new Version(version.Major, version.Minor, version.Build, version.Revision);
    }
  }
}
