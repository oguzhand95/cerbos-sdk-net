// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: buf/validate/expression.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Buf.Validate {

  /// <summary>Holder for reflection information generated from buf/validate/expression.proto</summary>
  public static partial class ExpressionReflection {

    #region Descriptor
    /// <summary>File descriptor for buf/validate/expression.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExpressionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1idWYvdmFsaWRhdGUvZXhwcmVzc2lvbi5wcm90bxIMYnVmLnZhbGlkYXRl",
            "IlYKCkNvbnN0cmFpbnQSDgoCaWQYASABKAlSAmlkEhgKB21lc3NhZ2UYAiAB",
            "KAlSB21lc3NhZ2USHgoKZXhwcmVzc2lvbhgDIAEoCVIKZXhwcmVzc2lvbiJF",
            "CgpWaW9sYXRpb25zEjcKCnZpb2xhdGlvbnMYASADKAsyFy5idWYudmFsaWRh",
            "dGUuVmlvbGF0aW9uUgp2aW9sYXRpb25zIoIBCglWaW9sYXRpb24SHQoKZmll",
            "bGRfcGF0aBgBIAEoCVIJZmllbGRQYXRoEiMKDWNvbnN0cmFpbnRfaWQYAiAB",
            "KAlSDGNvbnN0cmFpbnRJZBIYCgdtZXNzYWdlGAMgASgJUgdtZXNzYWdlEhcK",
            "B2Zvcl9rZXkYBCABKAhSBmZvcktleUJwChJidWlsZC5idWYudmFsaWRhdGVC",
            "D0V4cHJlc3Npb25Qcm90b1ABWkdidWYuYnVpbGQvZ2VuL2dvL2J1ZmJ1aWxk",
            "L3Byb3RvdmFsaWRhdGUvcHJvdG9jb2xidWZmZXJzL2dvL2J1Zi92YWxpZGF0",
            "ZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Buf.Validate.Constraint), global::Buf.Validate.Constraint.Parser, new[]{ "Id", "Message", "Expression" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Buf.Validate.Violations), global::Buf.Validate.Violations.Parser, new[]{ "Violations_" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Buf.Validate.Violation), global::Buf.Validate.Violation.Parser, new[]{ "FieldPath", "ConstraintId", "Message", "ForKey" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// `Constraint` represents a validation rule written in the Common Expression
  /// Language (CEL) syntax. Each Constraint includes a unique identifier, an
  /// optional error message, and the CEL expression to evaluate. For more
  /// information on CEL, [see our documentation](https://github.com/bufbuild/protovalidate/blob/main/docs/cel.md).
  ///
  /// ```proto
  /// message Foo {
  ///   option (buf.validate.message).cel = {
  ///     id: "foo.bar"
  ///     message: "bar must be greater than 0"
  ///     expression: "this.bar > 0"
  ///   };
  ///   int32 bar = 1;
  /// }
  /// ```
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Constraint : pb::IMessage<Constraint>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Constraint> _parser = new pb::MessageParser<Constraint>(() => new Constraint());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Constraint> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Buf.Validate.ExpressionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Constraint() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Constraint(Constraint other) : this() {
      id_ = other.id_;
      message_ = other.message_;
      expression_ = other.expression_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Constraint Clone() {
      return new Constraint(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    /// <summary>
    /// `id` is a string that serves as a machine-readable name for this Constraint.
    /// It should be unique within its scope, which could be either a message or a field.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 2;
    private string message_ = "";
    /// <summary>
    /// `message` is an optional field that provides a human-readable error message
    /// for this Constraint when the CEL expression evaluates to false. If a
    /// non-empty message is provided, any strings resulting from the CEL
    /// expression evaluation are ignored.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "expression" field.</summary>
    public const int ExpressionFieldNumber = 3;
    private string expression_ = "";
    /// <summary>
    /// `expression` is the actual CEL expression that will be evaluated for
    /// validation. This string must resolve to either a boolean or a string
    /// value. If the expression evaluates to false or a non-empty string, the
    /// validation is considered failed, and the message is rejected.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Expression {
      get { return expression_; }
      set {
        expression_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Constraint);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Constraint other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Message != other.Message) return false;
      if (Expression != other.Expression) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      if (Expression.Length != 0) hash ^= Expression.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Message);
      }
      if (Expression.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Expression);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Message);
      }
      if (Expression.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Expression);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (Expression.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Expression);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Constraint other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
      if (other.Expression.Length != 0) {
        Expression = other.Expression;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            Message = input.ReadString();
            break;
          }
          case 26: {
            Expression = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            Message = input.ReadString();
            break;
          }
          case 26: {
            Expression = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// `Violations` is a collection of `Violation` messages. This message type is returned by
  /// protovalidate when a proto message fails to meet the requirements set by the `Constraint` validation rules.
  /// Each individual violation is represented by a `Violation` message.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Violations : pb::IMessage<Violations>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Violations> _parser = new pb::MessageParser<Violations>(() => new Violations());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Violations> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Buf.Validate.ExpressionReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Violations() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Violations(Violations other) : this() {
      violations_ = other.violations_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Violations Clone() {
      return new Violations(this);
    }

    /// <summary>Field number for the "violations" field.</summary>
    public const int Violations_FieldNumber = 1;
    private static readonly pb::FieldCodec<global::Buf.Validate.Violation> _repeated_violations_codec
        = pb::FieldCodec.ForMessage(10, global::Buf.Validate.Violation.Parser);
    private readonly pbc::RepeatedField<global::Buf.Validate.Violation> violations_ = new pbc::RepeatedField<global::Buf.Validate.Violation>();
    /// <summary>
    /// `violations` is a repeated field that contains all the `Violation` messages corresponding to the violations detected.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Buf.Validate.Violation> Violations_ {
      get { return violations_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Violations);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Violations other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!violations_.Equals(other.violations_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= violations_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      violations_.WriteTo(output, _repeated_violations_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      violations_.WriteTo(ref output, _repeated_violations_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += violations_.CalculateSize(_repeated_violations_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Violations other) {
      if (other == null) {
        return;
      }
      violations_.Add(other.violations_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            violations_.AddEntriesFrom(input, _repeated_violations_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            violations_.AddEntriesFrom(ref input, _repeated_violations_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// `Violation` represents a single instance where a validation rule, expressed
  /// as a `Constraint`, was not met. It provides information about the field that
  /// caused the violation, the specific constraint that wasn't fulfilled, and a
  /// human-readable error message.
  ///
  /// ```json
  /// {
  ///   "fieldPath": "bar",
  ///   "constraintId": "foo.bar",
  ///   "message": "bar must be greater than 0"
  /// }
  /// ```
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Violation : pb::IMessage<Violation>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Violation> _parser = new pb::MessageParser<Violation>(() => new Violation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Violation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Buf.Validate.ExpressionReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Violation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Violation(Violation other) : this() {
      fieldPath_ = other.fieldPath_;
      constraintId_ = other.constraintId_;
      message_ = other.message_;
      forKey_ = other.forKey_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Violation Clone() {
      return new Violation(this);
    }

    /// <summary>Field number for the "field_path" field.</summary>
    public const int FieldPathFieldNumber = 1;
    private string fieldPath_ = "";
    /// <summary>
    /// `field_path` is a machine-readable identifier that points to the specific field that failed the validation.
    /// This could be a nested field, in which case the path will include all the parent fields leading to the actual field that caused the violation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string FieldPath {
      get { return fieldPath_; }
      set {
        fieldPath_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "constraint_id" field.</summary>
    public const int ConstraintIdFieldNumber = 2;
    private string constraintId_ = "";
    /// <summary>
    /// `constraint_id` is the unique identifier of the `Constraint` that was not fulfilled.
    /// This is the same `id` that was specified in the `Constraint` message, allowing easy tracing of which rule was violated.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ConstraintId {
      get { return constraintId_; }
      set {
        constraintId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 3;
    private string message_ = "";
    /// <summary>
    /// `message` is a human-readable error message that describes the nature of the violation.
    /// This can be the default error message from the violated `Constraint`, or it can be a custom message that gives more context about the violation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "for_key" field.</summary>
    public const int ForKeyFieldNumber = 4;
    private bool forKey_;
    /// <summary>
    /// `for_key` indicates whether the violation was caused by a map key, rather than a value.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool ForKey {
      get { return forKey_; }
      set {
        forKey_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Violation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Violation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FieldPath != other.FieldPath) return false;
      if (ConstraintId != other.ConstraintId) return false;
      if (Message != other.Message) return false;
      if (ForKey != other.ForKey) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FieldPath.Length != 0) hash ^= FieldPath.GetHashCode();
      if (ConstraintId.Length != 0) hash ^= ConstraintId.GetHashCode();
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      if (ForKey != false) hash ^= ForKey.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (FieldPath.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(FieldPath);
      }
      if (ConstraintId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ConstraintId);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Message);
      }
      if (ForKey != false) {
        output.WriteRawTag(32);
        output.WriteBool(ForKey);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (FieldPath.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(FieldPath);
      }
      if (ConstraintId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ConstraintId);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Message);
      }
      if (ForKey != false) {
        output.WriteRawTag(32);
        output.WriteBool(ForKey);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (FieldPath.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FieldPath);
      }
      if (ConstraintId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ConstraintId);
      }
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (ForKey != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Violation other) {
      if (other == null) {
        return;
      }
      if (other.FieldPath.Length != 0) {
        FieldPath = other.FieldPath;
      }
      if (other.ConstraintId.Length != 0) {
        ConstraintId = other.ConstraintId;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
      if (other.ForKey != false) {
        ForKey = other.ForKey;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            FieldPath = input.ReadString();
            break;
          }
          case 18: {
            ConstraintId = input.ReadString();
            break;
          }
          case 26: {
            Message = input.ReadString();
            break;
          }
          case 32: {
            ForKey = input.ReadBool();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            FieldPath = input.ReadString();
            break;
          }
          case 18: {
            ConstraintId = input.ReadString();
            break;
          }
          case 26: {
            Message = input.ReadString();
            break;
          }
          case 32: {
            ForKey = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
