// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
    internal sealed class ExprFieldInfo : ExprWithType
    {
        public ExprFieldInfo(FieldSymbol f, AggregateType ft, CType type)
            : base(type)
        {
            Field = f;
            FieldType = ft;
        }

        public FieldSymbol Field { get; }

        public AggregateType FieldType { get; }

        public override ExpressionKind Kind => ExpressionKind.EK_FIELDINFO;
    }
}
