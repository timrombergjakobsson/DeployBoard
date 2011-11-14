require 'rubygems'
require 'albacore'

task :default => ['hello']

desc 'says hello'
task :hello do
	puts 'hello world'
end

desc "NUnit Test Runner Example"
nnunit do |nunit|
		nunit.command = "NUint/ninit-console.exe"
		nunit.assemblies "assemblies/TestSolution.Tests.dll"
end