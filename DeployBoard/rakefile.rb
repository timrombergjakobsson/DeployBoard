require 'rubygems'
require 'albacore'

task :default => ['hello', 'nunit']

desc 'says hello'
task :hello do
	puts 'hello world'
end

desc "NUnit Test Runner Example"
nnunit do |nunit|
		nunit.command = "tools/nunit/nunit-console.exe"
		nunit.assemblies "bin/DeployBoard.Specs.dll"
end