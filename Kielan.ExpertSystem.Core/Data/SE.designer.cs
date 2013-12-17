﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kielan.ExpertSystem.Core.Data
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SystemEkspercki")]
	public partial class SEDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAnswer(Answer instance);
    partial void UpdateAnswer(Answer instance);
    partial void DeleteAnswer(Answer instance);
    partial void InsertConclusion(Conclusion instance);
    partial void UpdateConclusion(Conclusion instance);
    partial void DeleteConclusion(Conclusion instance);
    partial void InsertFact(Fact instance);
    partial void UpdateFact(Fact instance);
    partial void DeleteFact(Fact instance);
    partial void InsertPattern(Pattern instance);
    partial void UpdatePattern(Pattern instance);
    partial void DeletePattern(Pattern instance);
    partial void InsertQuestion(Question instance);
    partial void UpdateQuestion(Question instance);
    partial void DeleteQuestion(Question instance);
    partial void InsertRule(Rule instance);
    partial void UpdateRule(Rule instance);
    partial void DeleteRule(Rule instance);
    #endregion
		
		public SEDataContext() : 
				base(global::Kielan.ExpertSystem.Core.Properties.Settings.Default.SystemEksperckiConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SEDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SEDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SEDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SEDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Answer> Answers
		{
			get
			{
				return this.GetTable<Answer>();
			}
		}
		
		public System.Data.Linq.Table<Conclusion> Conclusions
		{
			get
			{
				return this.GetTable<Conclusion>();
			}
		}
		
		public System.Data.Linq.Table<Fact> Facts
		{
			get
			{
				return this.GetTable<Fact>();
			}
		}
		
		public System.Data.Linq.Table<Pattern> Patterns
		{
			get
			{
				return this.GetTable<Pattern>();
			}
		}
		
		public System.Data.Linq.Table<Question> Questions
		{
			get
			{
				return this.GetTable<Question>();
			}
		}
		
		public System.Data.Linq.Table<Rule> Rules
		{
			get
			{
				return this.GetTable<Rule>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Answers")]
	public partial class Answer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _QuestionId;
		
		private int _FactId;
		
		private EntityRef<Fact> _Fact;
		
		private EntityRef<Question> _Question;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnQuestionIdChanging(int value);
    partial void OnQuestionIdChanged();
    partial void OnFactIdChanging(int value);
    partial void OnFactIdChanged();
    #endregion
		
		public Answer()
		{
			this._Fact = default(EntityRef<Fact>);
			this._Question = default(EntityRef<Question>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuestionId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int QuestionId
		{
			get
			{
				return this._QuestionId;
			}
			set
			{
				if ((this._QuestionId != value))
				{
					if (this._Question.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnQuestionIdChanging(value);
					this.SendPropertyChanging();
					this._QuestionId = value;
					this.SendPropertyChanged("QuestionId");
					this.OnQuestionIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FactId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int FactId
		{
			get
			{
				return this._FactId;
			}
			set
			{
				if ((this._FactId != value))
				{
					if (this._Fact.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnFactIdChanging(value);
					this.SendPropertyChanging();
					this._FactId = value;
					this.SendPropertyChanged("FactId");
					this.OnFactIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Fact_Answer", Storage="_Fact", ThisKey="FactId", OtherKey="FactId", IsForeignKey=true)]
		public Fact Fact
		{
			get
			{
				return this._Fact.Entity;
			}
			set
			{
				Fact previousValue = this._Fact.Entity;
				if (((previousValue != value) 
							|| (this._Fact.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Fact.Entity = null;
						previousValue.Answers.Remove(this);
					}
					this._Fact.Entity = value;
					if ((value != null))
					{
						value.Answers.Add(this);
						this._FactId = value.FactId;
					}
					else
					{
						this._FactId = default(int);
					}
					this.SendPropertyChanged("Fact");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Question_Answer", Storage="_Question", ThisKey="QuestionId", OtherKey="QuestionId", IsForeignKey=true)]
		public Question Question
		{
			get
			{
				return this._Question.Entity;
			}
			set
			{
				Question previousValue = this._Question.Entity;
				if (((previousValue != value) 
							|| (this._Question.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Question.Entity = null;
						previousValue.Answers.Remove(this);
					}
					this._Question.Entity = value;
					if ((value != null))
					{
						value.Answers.Add(this);
						this._QuestionId = value.QuestionId;
					}
					else
					{
						this._QuestionId = default(int);
					}
					this.SendPropertyChanged("Question");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Conclusions")]
	public partial class Conclusion : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ConclusionId;
		
		private string _Name;
		
		private double _Cf;
		
		private EntityRef<Rule> _Rule;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnConclusionIdChanging(int value);
    partial void OnConclusionIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnCfChanging(double value);
    partial void OnCfChanged();
    #endregion
		
		public Conclusion()
		{
			this._Rule = default(EntityRef<Rule>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ConclusionId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ConclusionId
		{
			get
			{
				return this._ConclusionId;
			}
			set
			{
				if ((this._ConclusionId != value))
				{
					this.OnConclusionIdChanging(value);
					this.SendPropertyChanging();
					this._ConclusionId = value;
					this.SendPropertyChanged("ConclusionId");
					this.OnConclusionIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(130) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cf", DbType="Float NOT NULL")]
		public double Cf
		{
			get
			{
				return this._Cf;
			}
			set
			{
				if ((this._Cf != value))
				{
					this.OnCfChanging(value);
					this.SendPropertyChanging();
					this._Cf = value;
					this.SendPropertyChanged("Cf");
					this.OnCfChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Conclusion_Rule", Storage="_Rule", ThisKey="ConclusionId", OtherKey="RuleId", IsUnique=true, IsForeignKey=false)]
		public Rule Rule
		{
			get
			{
				return this._Rule.Entity;
			}
			set
			{
				Rule previousValue = this._Rule.Entity;
				if (((previousValue != value) 
							|| (this._Rule.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Rule.Entity = null;
						previousValue.Conclusion = null;
					}
					this._Rule.Entity = value;
					if ((value != null))
					{
						value.Conclusion = this;
					}
					this.SendPropertyChanged("Rule");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Facts")]
	public partial class Fact : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _FactId;
		
		private string _Text;
		
		private double _Cf;
		
		private EntitySet<Answer> _Answers;
		
		private EntitySet<Pattern> _Patterns;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnFactIdChanging(int value);
    partial void OnFactIdChanged();
    partial void OnTextChanging(string value);
    partial void OnTextChanged();
    partial void OnCfChanging(double value);
    partial void OnCfChanged();
    #endregion
		
		public Fact()
		{
			this._Answers = new EntitySet<Answer>(new Action<Answer>(this.attach_Answers), new Action<Answer>(this.detach_Answers));
			this._Patterns = new EntitySet<Pattern>(new Action<Pattern>(this.attach_Patterns), new Action<Pattern>(this.detach_Patterns));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FactId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int FactId
		{
			get
			{
				return this._FactId;
			}
			set
			{
				if ((this._FactId != value))
				{
					this.OnFactIdChanging(value);
					this.SendPropertyChanging();
					this._FactId = value;
					this.SendPropertyChanged("FactId");
					this.OnFactIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Text", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Text
		{
			get
			{
				return this._Text;
			}
			set
			{
				if ((this._Text != value))
				{
					this.OnTextChanging(value);
					this.SendPropertyChanging();
					this._Text = value;
					this.SendPropertyChanged("Text");
					this.OnTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cf", DbType="Float NOT NULL")]
		public double Cf
		{
			get
			{
				return this._Cf;
			}
			set
			{
				if ((this._Cf != value))
				{
					this.OnCfChanging(value);
					this.SendPropertyChanging();
					this._Cf = value;
					this.SendPropertyChanged("Cf");
					this.OnCfChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Fact_Answer", Storage="_Answers", ThisKey="FactId", OtherKey="FactId")]
		public EntitySet<Answer> Answers
		{
			get
			{
				return this._Answers;
			}
			set
			{
				this._Answers.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Fact_Pattern", Storage="_Patterns", ThisKey="FactId", OtherKey="FactId")]
		public EntitySet<Pattern> Patterns
		{
			get
			{
				return this._Patterns;
			}
			set
			{
				this._Patterns.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Answers(Answer entity)
		{
			this.SendPropertyChanging();
			entity.Fact = this;
		}
		
		private void detach_Answers(Answer entity)
		{
			this.SendPropertyChanging();
			entity.Fact = null;
		}
		
		private void attach_Patterns(Pattern entity)
		{
			this.SendPropertyChanging();
			entity.Fact = this;
		}
		
		private void detach_Patterns(Pattern entity)
		{
			this.SendPropertyChanging();
			entity.Fact = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Patterns")]
	public partial class Pattern : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _FactId;
		
		private int _RuleId;
		
		private EntityRef<Fact> _Fact;
		
		private EntityRef<Rule> _Rule;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnFactIdChanging(int value);
    partial void OnFactIdChanged();
    partial void OnRuleIdChanging(int value);
    partial void OnRuleIdChanged();
    #endregion
		
		public Pattern()
		{
			this._Fact = default(EntityRef<Fact>);
			this._Rule = default(EntityRef<Rule>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FactId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int FactId
		{
			get
			{
				return this._FactId;
			}
			set
			{
				if ((this._FactId != value))
				{
					if (this._Fact.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnFactIdChanging(value);
					this.SendPropertyChanging();
					this._FactId = value;
					this.SendPropertyChanged("FactId");
					this.OnFactIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RuleId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int RuleId
		{
			get
			{
				return this._RuleId;
			}
			set
			{
				if ((this._RuleId != value))
				{
					if (this._Rule.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRuleIdChanging(value);
					this.SendPropertyChanging();
					this._RuleId = value;
					this.SendPropertyChanged("RuleId");
					this.OnRuleIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Fact_Pattern", Storage="_Fact", ThisKey="FactId", OtherKey="FactId", IsForeignKey=true)]
		public Fact Fact
		{
			get
			{
				return this._Fact.Entity;
			}
			set
			{
				Fact previousValue = this._Fact.Entity;
				if (((previousValue != value) 
							|| (this._Fact.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Fact.Entity = null;
						previousValue.Patterns.Remove(this);
					}
					this._Fact.Entity = value;
					if ((value != null))
					{
						value.Patterns.Add(this);
						this._FactId = value.FactId;
					}
					else
					{
						this._FactId = default(int);
					}
					this.SendPropertyChanged("Fact");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Rule_Pattern", Storage="_Rule", ThisKey="RuleId", OtherKey="RuleId", IsForeignKey=true)]
		public Rule Rule
		{
			get
			{
				return this._Rule.Entity;
			}
			set
			{
				Rule previousValue = this._Rule.Entity;
				if (((previousValue != value) 
							|| (this._Rule.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Rule.Entity = null;
						previousValue.Patterns.Remove(this);
					}
					this._Rule.Entity = value;
					if ((value != null))
					{
						value.Patterns.Add(this);
						this._RuleId = value.RuleId;
					}
					else
					{
						this._RuleId = default(int);
					}
					this.SendPropertyChanged("Rule");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Questions")]
	public partial class Question : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _QuestionId;
		
		private string _Text;
		
		private EntitySet<Answer> _Answers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnQuestionIdChanging(int value);
    partial void OnQuestionIdChanged();
    partial void OnTextChanging(string value);
    partial void OnTextChanged();
    #endregion
		
		public Question()
		{
			this._Answers = new EntitySet<Answer>(new Action<Answer>(this.attach_Answers), new Action<Answer>(this.detach_Answers));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuestionId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int QuestionId
		{
			get
			{
				return this._QuestionId;
			}
			set
			{
				if ((this._QuestionId != value))
				{
					this.OnQuestionIdChanging(value);
					this.SendPropertyChanging();
					this._QuestionId = value;
					this.SendPropertyChanged("QuestionId");
					this.OnQuestionIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Text", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Text
		{
			get
			{
				return this._Text;
			}
			set
			{
				if ((this._Text != value))
				{
					this.OnTextChanging(value);
					this.SendPropertyChanging();
					this._Text = value;
					this.SendPropertyChanged("Text");
					this.OnTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Question_Answer", Storage="_Answers", ThisKey="QuestionId", OtherKey="QuestionId")]
		public EntitySet<Answer> Answers
		{
			get
			{
				return this._Answers;
			}
			set
			{
				this._Answers.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Answers(Answer entity)
		{
			this.SendPropertyChanging();
			entity.Question = this;
		}
		
		private void detach_Answers(Answer entity)
		{
			this.SendPropertyChanging();
			entity.Question = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Rules")]
	public partial class Rule : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RuleId;
		
		private string _Text;
		
		private string _Comment;
		
		private int _ConclusionId;
		
		private EntitySet<Pattern> _Patterns;
		
		private EntityRef<Conclusion> _Conclusion;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRuleIdChanging(int value);
    partial void OnRuleIdChanged();
    partial void OnTextChanging(string value);
    partial void OnTextChanged();
    partial void OnCommentChanging(string value);
    partial void OnCommentChanged();
    partial void OnConclusionIdChanging(int value);
    partial void OnConclusionIdChanged();
    #endregion
		
		public Rule()
		{
			this._Patterns = new EntitySet<Pattern>(new Action<Pattern>(this.attach_Patterns), new Action<Pattern>(this.detach_Patterns));
			this._Conclusion = default(EntityRef<Conclusion>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RuleId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int RuleId
		{
			get
			{
				return this._RuleId;
			}
			set
			{
				if ((this._RuleId != value))
				{
					if (this._Conclusion.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRuleIdChanging(value);
					this.SendPropertyChanging();
					this._RuleId = value;
					this.SendPropertyChanged("RuleId");
					this.OnRuleIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Text", DbType="NVarChar(100)")]
		public string Text
		{
			get
			{
				return this._Text;
			}
			set
			{
				if ((this._Text != value))
				{
					this.OnTextChanging(value);
					this.SendPropertyChanging();
					this._Text = value;
					this.SendPropertyChanged("Text");
					this.OnTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Comment", DbType="NVarChar(100)")]
		public string Comment
		{
			get
			{
				return this._Comment;
			}
			set
			{
				if ((this._Comment != value))
				{
					this.OnCommentChanging(value);
					this.SendPropertyChanging();
					this._Comment = value;
					this.SendPropertyChanged("Comment");
					this.OnCommentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ConclusionId", DbType="Int NOT NULL")]
		public int ConclusionId
		{
			get
			{
				return this._ConclusionId;
			}
			set
			{
				if ((this._ConclusionId != value))
				{
					this.OnConclusionIdChanging(value);
					this.SendPropertyChanging();
					this._ConclusionId = value;
					this.SendPropertyChanged("ConclusionId");
					this.OnConclusionIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Rule_Pattern", Storage="_Patterns", ThisKey="RuleId", OtherKey="RuleId")]
		public EntitySet<Pattern> Patterns
		{
			get
			{
				return this._Patterns;
			}
			set
			{
				this._Patterns.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Conclusion_Rule", Storage="_Conclusion", ThisKey="RuleId", OtherKey="ConclusionId", IsForeignKey=true)]
		public Conclusion Conclusion
		{
			get
			{
				return this._Conclusion.Entity;
			}
			set
			{
				Conclusion previousValue = this._Conclusion.Entity;
				if (((previousValue != value) 
							|| (this._Conclusion.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Conclusion.Entity = null;
						previousValue.Rule = null;
					}
					this._Conclusion.Entity = value;
					if ((value != null))
					{
						value.Rule = this;
						this._RuleId = value.ConclusionId;
					}
					else
					{
						this._RuleId = default(int);
					}
					this.SendPropertyChanged("Conclusion");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Patterns(Pattern entity)
		{
			this.SendPropertyChanging();
			entity.Rule = this;
		}
		
		private void detach_Patterns(Pattern entity)
		{
			this.SendPropertyChanging();
			entity.Rule = null;
		}
	}
}
#pragma warning restore 1591