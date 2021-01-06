# MySQL_Bug_101236
This project is for reproducing the bug 101236.

Workthrough:
1. Create wpf project.
2. Install nuget MySql.Data.EntityFramework v8.0.22.
3. Create model by code first.
4. Execuate query to entity.
5. "MySqlException: Table 'schema.schema.table' doesn't exist" prompted.

Current solution:
1. Install nuget MySql.Data.EntityFramework v8.0.22.
2. Downgrade nuget to v8.0.21.
3. Since v8.0.21 has another bug that I can't create model through wizard, so I copy model created from v8.0.22.
4. Query works find.

Stack Trace:   於 System.Environment.GetStackTrace(Exception e, Boolean needFileInfo)
   於 System.Environment.get_StackTrace()
   於 System.Data.Entity.Core.Objects.ObjectContext.ExecuteInTransaction[T](Func`1 func, IDbExecutionStrategy executionStrategy, Boolean startLocalTransaction, Boolean releaseConnectionOnSuccess)
   於 System.Data.Entity.Core.Objects.ObjectQuery`1.<>c__DisplayClass41_0.<GetResults>b__0()
   於 System.Data.Entity.Infrastructure.DefaultExecutionStrategy.Execute[TResult](Func`1 operation)
   於 System.Data.Entity.Core.Objects.ObjectQuery`1.GetResults(Nullable`1 forMergeOption)
   於 System.Data.Entity.Core.Objects.ObjectQuery`1.<System.Collections.Generic.IEnumerable<T>.GetEnumerator>b__31_0()
   於 System.Data.Entity.Internal.LazyEnumerator`1.MoveNext()
   於 System.Linq.Buffer`1..ctor(IEnumerable`1 source)
   於 System.Linq.Enumerable.ToArray[TSource](IEnumerable`1 source)
   於 MySQL_Bug_101236_v8._0._22.MainWindow..ctor() 於 C:\Users\Zenbon\source\repos\MySQL_Bug_101236\MySQL_Bug_101236_v8.0.22\MainWindow.xaml.cs: 行 29
   於 System.RuntimeTypeHandle.CreateInstance(RuntimeType type, Boolean publicOnly, Boolean noCheck, Boolean& canBeCached, RuntimeMethodHandleInternal& ctor, Boolean& bNeedSecurityCheck)
   於 System.RuntimeType.CreateInstanceSlow(Boolean publicOnly, Boolean skipCheckThis, Boolean fillCache, StackCrawlMark& stackMark)
   於 System.RuntimeType.CreateInstanceDefaultCtor(Boolean publicOnly, Boolean skipCheckThis, Boolean fillCache, StackCrawlMark& stackMark)
   於 System.Activator.CreateInstance(Type type, Boolean nonPublic)
   於 System.RuntimeType.CreateInstanceImpl(BindingFlags bindingAttr, Binder binder, Object[] args, CultureInfo culture, Object[] activationAttributes, StackCrawlMark& stackMark)
   於 System.Activator.CreateInstance(Type type, BindingFlags bindingAttr, Binder binder, Object[] args, CultureInfo culture, Object[] activationAttributes)
   於 System.Activator.CreateInstance(Type type, Object[] args)
   於 System.Xaml.Schema.SafeReflectionInvoker.CreateInstanceCritical(Type type, Object[] arguments)
   於 System.Xaml.Schema.SafeReflectionInvoker.CreateInstance(Type type, Object[] arguments)
   於 System.Xaml.Schema.XamlTypeInvoker.CreateInstance(Object[] arguments)
   於 MS.Internal.Xaml.Runtime.ClrObjectRuntime.CreateInstanceWithCtor(XamlType xamlType, Object[] args)
   於 MS.Internal.Xaml.Runtime.ClrObjectRuntime.CreateInstance(XamlType xamlType, Object[] args)
   於 System.Xaml.XamlObjectWriter.Logic_CreateAndAssignToParentStart(ObjectWriterContext ctx)
   於 System.Xaml.XamlObjectWriter.WriteStartMember(XamlMember property)
   於 System.Xaml.XamlWriter.WriteNode(XamlReader reader)
   於 System.Windows.Markup.WpfXamlLoader.TransformNodes(XamlReader xamlReader, XamlObjectWriter xamlWriter, Boolean onlyLoadOneNode, Boolean skipJournaledProperties, Boolean shouldPassLineNumberInfo, IXamlLineInfo xamlLineInfo, IXamlLineInfoConsumer xamlLineInfoConsumer, XamlContextStack`1 stack, IStyleConnector styleConnector)
   於 System.Windows.Markup.WpfXamlLoader.Load(XamlReader xamlReader, IXamlObjectWriterFactory writerFactory, Boolean skipJournaledProperties, Object rootObject, XamlObjectWriterSettings settings, Uri baseUri)
   於 System.Windows.Markup.WpfXamlLoader.LoadBaml(XamlReader xamlReader, Boolean skipJournaledProperties, Object rootObject, XamlAccessLevel accessLevel, Uri baseUri)
   於 System.Windows.Markup.XamlReader.LoadBaml(Stream stream, ParserContext parserContext, Object parent, Boolean closeStream)
   於 System.Windows.Application.LoadBamlStreamWithSyncInfo(Stream stream, ParserContext pc)
   於 System.Windows.Application.LoadComponent(Uri resourceLocator, Boolean bSkipJournaledProperties)
   於 System.Windows.Application.DoStartup()
   於 System.Windows.Application.<.ctor>b__1_0(Object unused)
   於 System.Windows.Threading.ExceptionWrapper.InternalRealCall(Delegate callback, Object args, Int32 numArgs)
   於 System.Windows.Threading.ExceptionWrapper.TryCatchWhen(Object source, Delegate callback, Object args, Int32 numArgs, Delegate catchHandler)
   於 System.Windows.Threading.DispatcherOperation.InvokeImpl()
   於 System.Windows.Threading.DispatcherOperation.InvokeInSecurityContext(Object state)
   於 MS.Internal.CulturePreservingExecutionContext.CallbackWrapper(Object obj)
   於 System.Threading.ExecutionContext.RunInternal(ExecutionContext executionContext, ContextCallback callback, Object state, Boolean preserveSyncCtx)
   於 System.Threading.ExecutionContext.Run(ExecutionContext executionContext, ContextCallback callback, Object state, Boolean preserveSyncCtx)
   於 System.Threading.ExecutionContext.Run(ExecutionContext executionContext, ContextCallback callback, Object state)
   於 MS.Internal.CulturePreservingExecutionContext.Run(CulturePreservingExecutionContext executionContext, ContextCallback callback, Object state)
   於 System.Windows.Threading.DispatcherOperation.Invoke()
   於 System.Windows.Threading.Dispatcher.ProcessQueue()
   於 System.Windows.Threading.Dispatcher.WndProcHook(IntPtr hwnd, Int32 msg, IntPtr wParam, IntPtr lParam, Boolean& handled)
   於 MS.Win32.HwndWrapper.WndProc(IntPtr hwnd, Int32 msg, IntPtr wParam, IntPtr lParam, Boolean& handled)
   於 MS.Win32.HwndSubclass.DispatcherCallbackOperation(Object o)
   於 System.Windows.Threading.ExceptionWrapper.InternalRealCall(Delegate callback, Object args, Int32 numArgs)
   於 System.Windows.Threading.ExceptionWrapper.TryCatchWhen(Object source, Delegate callback, Object args, Int32 numArgs, Delegate catchHandler)
   於 System.Windows.Threading.Dispatcher.LegacyInvokeImpl(DispatcherPriority priority, TimeSpan timeout, Delegate method, Object args, Int32 numArgs)
   於 MS.Win32.HwndSubclass.SubclassWndProc(IntPtr hwnd, Int32 msg, IntPtr wParam, IntPtr lParam)
   於 MS.Win32.UnsafeNativeMethods.DispatchMessage(MSG& msg)
   於 System.Windows.Threading.Dispatcher.PushFrameImpl(DispatcherFrame frame)
   於 System.Windows.Threading.Dispatcher.PushFrame(DispatcherFrame frame)
   於 System.Windows.Application.RunDispatcher(Object ignore)
   於 System.Windows.Application.RunInternal(Window window)
   於 System.Windows.Application.Run(Window window)
   於 System.Windows.Application.Run()
   於 MySQL_Bug_101236_v8._0._22.App.Main()
